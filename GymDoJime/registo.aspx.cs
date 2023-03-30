using GymDoJime.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymDoJime
{
    public partial class registo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = tbnome.Text;
                string email = tbEmail.Text;
                string password = tbpassword.Text;
                DateTime dataNasc = DateTime.Parse(tbNascimento.Text);
                string cc = tbCC.Text;
                string nif = tbnif.Text;
                int nacionalidade = ddnacionalidade.SelectedIndex;
                int perfil = dpPerfil.SelectedIndex;
                string telefone = tbtelefone.Text;
                int genero = dpGenero.SelectedIndex;
                int indade = int.Parse(tbIdade.Text);

                
                if (nome.Length < 3  /*Regex.IsMatch(nome, @"[0-9]"/*/)
                {
                    throw new Exception("Nome inválido, deve introduzir um nome sem numeros e mais que tres caracteres");
                }


                if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"))
                {
                    throw new Exception("Email invalido");
                }

                if (dataNasc > DateTime.Now)
                {
                    throw new Exception("Data de nascimento invalida. A data deve ser menor que a data atual");
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

                Utilizadores utilizador = new Utilizadores();

                utilizador.nome = nome;
                utilizador.email = email;
                utilizador.password = password;
                utilizador.dataNasc = dataNasc;
                utilizador.cc = cc;
                utilizador.nif = nif;
                utilizador.nacionalidade = nacionalidade;
                utilizador.idade = indade;
                utilizador.telefone = telefone;
                Random rmd = new Random();
                utilizador.sal = rmd.Next(9999);
                utilizador.genero = genero;
                utilizador.perfil = perfil;
                utilizador.Adicionar();

                lbErro.Text = "Registo feito com sucesso";
                ScriptManager.RegisterStartupScript(this, typeof(Page),
                    "Redirecionar", "returnMain('/index.aspx')", true);

            }
            catch (Exception ex)
            {
                lbErro.Text = "ocorreu o seguinte eerro: " + ex.Message;
                return;
            }







        }


        protected void btRecuperarPassword_Click(object sender, EventArgs e)
        {

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