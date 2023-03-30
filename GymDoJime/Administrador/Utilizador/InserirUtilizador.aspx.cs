using GymDoJime.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymDoJime.Administrador.Utilizador
{
    public partial class InserirUtilizador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            if (!IsPostBack)
            {
                AtualizarGrelha();
            }
        }

        private void AtualizarGrelha()
        {
            dgvUtilizadores.Columns.Clear();
            Utilizadores tt = new Utilizadores();
            DataTable dados = tt.ListaTodosLivros();

            DataColumn dcEditar = new DataColumn();
            dcEditar.ColumnName = "Editar";
            dcEditar.DataType = Type.GetType("System.String");
            dados.Columns.Add(dcEditar);

            DataColumn dcApagar = new DataColumn();
            dcApagar.ColumnName = "Apagar";
            dcApagar.DataType = Type.GetType("System.String");
            dados.Columns.Add(dcApagar);


            //Colunas da data grid view
            dgvUtilizadores.DataSource = dados;
            dgvUtilizadores.AutoGenerateColumns = false;


            //Editar
            HyperLinkField hlEditar = new HyperLinkField();
            hlEditar.HeaderText = "Editar";
            hlEditar.DataTextField = "Editar";
            hlEditar.Text = "Editar...";
            hlEditar.DataNavigateUrlFormatString = "AtualizarUtilizador.aspx?idutilizador={0}";
            hlEditar.DataNavigateUrlFields = new string[] { "idutilizador" };
            dgvUtilizadores.Columns.Add(hlEditar);


            //Apagar
            HyperLinkField hlApagar = new HyperLinkField();
            hlApagar.HeaderText = "Apagar";
            hlApagar.DataTextField = "Apagar";
            hlApagar.Text = "Apagar...";
            hlApagar.DataNavigateUrlFormatString = "DeleteUtilizador.aspx?idutilizador={0}";
            hlApagar.DataNavigateUrlFields = new string[] { "idutilizador" };
            dgvUtilizadores.Columns.Add(hlApagar);



            //idTreinador
            BoundField bfnTreinador = new BoundField();
            bfnTreinador.HeaderText = "Id utilizador";
            bfnTreinador.DataField = "idutilizador";
            dgvUtilizadores.Columns.Add(bfnTreinador);



            //Nome
            BoundField bfnNome = new BoundField();
            bfnNome.HeaderText = "Nome";
            bfnNome.DataField = "nome";
            dgvUtilizadores.Columns.Add(bfnNome);



            //Email
            BoundField bfnEamil = new BoundField();
            bfnEamil.HeaderText = "Email";
            bfnEamil.DataField = "email";
            dgvUtilizadores.Columns.Add(bfnEamil);



            //Senha
            BoundField bfnSenha = new BoundField();
            bfnSenha.HeaderText = "Senha (Encriptada)";
            bfnSenha.DataField = "password";
            dgvUtilizadores.Columns.Add(bfnSenha);



            //Data Nasciento
            BoundField bfnDataNasc = new BoundField();
            bfnDataNasc.HeaderText = "Data Nasciennto";
            bfnDataNasc.DataField = "data_nascimento";
            bfnDataNasc.DataFormatString = "{0:dd-MM-yyyy}";
            dgvUtilizadores.Columns.Add(bfnDataNasc);



            //cc
            BoundField bfnCC = new BoundField();
            bfnCC.HeaderText = "Cartão de Cidadão";
            bfnCC.DataField = "cc";
            dgvUtilizadores.Columns.Add(bfnCC);



            //nif
            BoundField bfnNif = new BoundField();
            bfnNif.HeaderText = "Numero de Identificação Fiscal";
            bfnNif.DataField = "nif";
            dgvUtilizadores.Columns.Add(bfnNif);



            //nacionalidade
            BoundField bfnNacionalidade = new BoundField();
            bfnNacionalidade.HeaderText = "Nacionalidade";
            bfnNacionalidade.DataField = "nacionalidade";
            dgvUtilizadores.Columns.Add(bfnNacionalidade);



            //Telefone
            BoundField bfnTelefone = new BoundField();
            bfnTelefone.HeaderText = "Telefone";
            bfnTelefone.DataField = "telefone";
            dgvUtilizadores.Columns.Add(bfnTelefone);



            //Genero
            BoundField bfnGenero = new BoundField();
            bfnGenero.HeaderText = "Genero";
            bfnGenero.DataField = "genero";
            dgvUtilizadores.Columns.Add(bfnGenero);



            //Perfil
            BoundField bfnPerfil = new BoundField();
            bfnGenero.HeaderText = "Perfil";
            bfnGenero.DataField = "perfil";
            dgvUtilizadores.Columns.Add(bfnPerfil);



            //Idade
            BoundField bfnIdade = new BoundField();
            bfnIdade.HeaderText = "Idade";
            bfnIdade.DataField = "idade";
            dgvUtilizadores.Columns.Add(bfnIdade);

            dgvUtilizadores.DataBind();
        }

        private void ConfigurarGrid()
        {
            dgvUtilizadores.AllowPaging = true;
            dgvUtilizadores.PageSize = 5;
            dgvUtilizadores.PageIndexChanging += dgvUtilizadores_PageIndexChanging;
        }

        private void dgvUtilizadores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvUtilizadores.PageIndex = e.NewPageIndex;
            AtualizarGrelha();
        }

        protected void tbNascimento_TextChanged(object sender, EventArgs e)
        {
            DateTime dataNasc = DateTime.Parse(tbNascimento.Text);

            dIdade.Visible = true;
            TimeSpan idade = DateTime.Now.Date - dataNasc.Date;
            tbIdade.Text = Math.Round((idade.TotalDays / 365), 0).ToString();
        }

        protected void btRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                int idade = int.Parse(tbIdade.Text);
                string nome = tbnome.Text;
                string email = tbEmail.Text;
                string password = tbpassword.Text;
                DateTime dataNasc = DateTime.Parse(tbNascimento.Text);
                string cc = tbCC.Text;
                string nif = tbnif.Text;
                int nacionalidade = int.Parse(ddnacionalidade.SelectedValue);
                int perfil = int.Parse(dpPerfil.SelectedValue);
                string telefone = tbtelefone.Text;
                int genero = dpGenero.SelectedIndex;


                if (nome.Length < 3  /*Regex.IsMatch(nome, @"[0-9]"/*/)
                {
                    throw new Exception("Nome inválido, deve introduzir um nome sem numeros e mais que tres caracteres");
                }


                if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"))
                {
                    throw new Exception("Email invalido");
                }

                if (dataNasc > DateTime.Now || dataNasc == null)
                {

                    throw new Exception("Data de nascimento invalida. A data deve ser menor que a data atual");


                }
                else
                {
                    dIdade.Visible = true;
                    TimeSpan idadeTreinador = DateTime.Now.Date - dataNasc.Date;
                    tbIdade.Text = (idadeTreinador.TotalDays / 365).ToString();
                }

                if (cc is null/*!Regex.IsMatch(cc, @"^[0 - 9]{8} [0 - 9] [A-Za - z]{2} [0 - 9]$")/*/)
                {
                    throw new Exception("Cartao de cidado invalido");
                }

                if (!Regex.IsMatch(nif, @"^[0-9]{9}"))
                {
                    throw new Exception("Numero de identificaçao fiscal invalido, deve conter 9 numeros ");
                }

                if (int.Parse(ddnacionalidade.SelectedValue) == 0)
                {
                    throw new Exception("Tem de selecionar uma nacionalidade");
                }

                if (!Regex.IsMatch(telefone, @"[0-9]{9}"))
                {
                    throw new Exception("Numero de telefone invalido");
                }

                Utilizadores ut = new Utilizadores();

                ut.nome = nome;
                ut.email = email;
                ut.password = password;
                ut.dataNasc = dataNasc;
                ut.cc = cc;
                ut.nif = nif;
                ut.nacionalidade = nacionalidade;
                ut.telefone = telefone;
                Random rmd = new Random();
                ut.sal = rmd.Next(9999);
                ut.genero = genero;
                ut.perfil = perfil;
                ut.idade = idade;
                ut.Adicionar();

                LimparForm();

                AtualizarGrelha();

                lbErro.Text = "Registo feito com sucesso";
                ScriptManager.RegisterStartupScript(this, typeof(Page),
                    "Redirecionar", "returnMain('InserirUtilizador.aspx')", true);





            }
            catch (Exception ex)
            {
                lbErro.Text = "ocorreu o seguinte eerro: " + ex.Message;
                return;
            }
        }

        private void LimparForm()
        {
            tbnome.Text = "";
            tbEmail.Text = "";
            tbpassword.Text = "";
            tbNascimento.Text = DateTime.Now.ToShortDateString();
            tbCC.Text = "";
            tbnif.Text = "";
            ddnacionalidade.SelectedIndex = 0;
            dpGenero.SelectedIndex = 0;
            dpPerfil.SelectedIndex = 0;

        }

        protected void btRecuperarPassword_Click(object sender, EventArgs e)
        {

        }
    }
}