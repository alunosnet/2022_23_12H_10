using GymDoJime.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymDoJime.Administrador.Treinadores
{
    public partial class InserirTreinadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ConfigurarGrid();
            if (!IsPostBack)
            {
                AtualizaGrelha();
            }
        }

        private void AtualizaGrelha()
        {
            dgvTreinadores.Columns.Clear();
            Treinador tt = new Treinador();
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
            dgvTreinadores.DataSource = dados;
            dgvTreinadores.AutoGenerateColumns = false;


            //Editar
            HyperLinkField hlEditar = new HyperLinkField();
            hlEditar.HeaderText = "Editar";
            hlEditar.DataTextField = "Editar";
            hlEditar.Text = "Editar...";
            hlEditar.DataNavigateUrlFormatString = "AtualizarTreinadores.aspx?idtreinador={0}";
            hlEditar.DataNavigateUrlFields = new string[] { "idtreinador" };
            dgvTreinadores.Columns.Add(hlEditar);


            //Apagar
            HyperLinkField hlApagar = new HyperLinkField();
            hlApagar.HeaderText = "Apagar";
            hlApagar.DataTextField = "Apagar";
            hlApagar.Text = "Apagar...";
            hlApagar.DataNavigateUrlFormatString = "DeleteTreinadores.aspx?idtreinador={0}";
            hlApagar.DataNavigateUrlFields = new string[] { "idtreinador" };
            dgvTreinadores.Columns.Add(hlApagar);



            //idTreinador
            BoundField bfnTreinador = new BoundField();
            bfnTreinador.HeaderText = "Id Treinador";
            bfnTreinador.DataField = "idtreinador";
            dgvTreinadores.Columns.Add(bfnTreinador);



            //Nome
            BoundField bfnNome = new BoundField();
            bfnNome.HeaderText = "Nome";
            bfnNome.DataField = "nomeTreinador";
            dgvTreinadores.Columns.Add(bfnNome);



            //Email
            BoundField bfnEamil = new BoundField();
            bfnEamil.HeaderText = "Email";
            bfnEamil.DataField = "emailTreinador";
            dgvTreinadores.Columns.Add(bfnEamil);



            //Senha
            BoundField bfnSenha = new BoundField();
            bfnSenha.HeaderText = "Senha (Encriptada)";
            bfnSenha.DataField = "password";
            dgvTreinadores.Columns.Add(bfnSenha);



            //Data Nasciento
            BoundField bfnDataNasc = new BoundField();
            bfnDataNasc.HeaderText = "Data Nasciennto";
            bfnDataNasc.DataField = "data_nasc";
            bfnDataNasc.DataFormatString = "{0:dd-MM-yyyy}";
            dgvTreinadores.Columns.Add(bfnDataNasc);



            //cc
            BoundField bfnCC = new BoundField();
            bfnCC.HeaderText = "Cartão de Cidadão";
            bfnCC.DataField = "ccTreinador";
            dgvTreinadores.Columns.Add(bfnCC);



            //nif
            BoundField bfnNif = new BoundField();
            bfnNif.HeaderText = "Numero de Identificação Fiscal";
            bfnNif.DataField = "nifTreinador";
            dgvTreinadores.Columns.Add(bfnNif);



            //nacionalidade
            BoundField bfnNacionalidade = new BoundField();
            bfnNacionalidade.HeaderText = "Nacionalidade";
            bfnNacionalidade.DataField = "nacionality";
            dgvTreinadores.Columns.Add(bfnNacionalidade);



            //Telefone
            BoundField bfnTelefone = new BoundField();
            bfnTelefone.HeaderText = "Telefone";
            bfnTelefone.DataField = "telefoneTreinador";
            dgvTreinadores.Columns.Add(bfnTelefone);



            //Genero
            BoundField bfnGenero = new BoundField();
            bfnGenero.HeaderText = "Genero";
            bfnGenero.DataField = "genero";
            dgvTreinadores.Columns.Add(bfnGenero);



            //Perfil
            BoundField bfnPerfil = new BoundField();
            bfnGenero.HeaderText = "Perfil";
            bfnGenero.DataField = "perfil";
            dgvTreinadores.Columns.Add(bfnPerfil);



            //Idade
            BoundField bfnIdade = new BoundField();
            bfnIdade.HeaderText = "Idade";
            bfnIdade.DataField = "idade";
            dgvTreinadores.Columns.Add(bfnIdade);

            dgvTreinadores.DataBind();

        }

        private void ConfigurarGrid()
        {
            dgvTreinadores.AllowPaging = true;
            dgvTreinadores.PageSize = 5;
            dgvTreinadores.PageIndexChanging += DgvTreinadores_PageIndexChanging;

        }

        private void DgvTreinadores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvTreinadores.PageIndex = e.NewPageIndex;
            AtualizaGrelha();
        }

        protected void btRecuperarPassword_Click(object sender, EventArgs e)
        {

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

                Treinador treinador = new Treinador();

                treinador.nome = nome;
                treinador.email = email;
                treinador.password = password;
                treinador.dataNasc = dataNasc;
                treinador.cc = cc;
                treinador.nif = nif;
                treinador.nacionalidade = nacionalidade.ToString();
                treinador.telefone = telefone;
                Random rmd = new Random();
                treinador.sal = rmd.Next(9999);
                treinador.genero = genero.ToString();
                treinador.perfil = perfil.ToString();
                treinador.idade = idade;
                treinador.Adicionar();

                LimparForm();

                AtualizaGrelha();

                lbErro.Text = "Registo feito com sucesso";
                ScriptManager.RegisterStartupScript(this, typeof(Page),
                    "Redirecionar", "returnMain('admin.aspx')", true);

               

               

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

        protected void tbNascimento_TextChanged(object sender, EventArgs e)
        {
            DateTime dataNasc = DateTime.Parse(tbNascimento.Text);

            dIdade.Visible = true;
            TimeSpan idade = DateTime.Now.Date - dataNasc.Date;
            tbIdade.Text = Math.Round((idade.TotalDays / 365), 0).ToString();
        }
    }
}