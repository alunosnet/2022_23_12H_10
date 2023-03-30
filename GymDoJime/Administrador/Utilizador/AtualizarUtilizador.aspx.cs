using GymDoJime.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymDoJime.Administrador.Utilizador
{
    public partial class AtualizarUtilizador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            try
            {
                int idUtilizador = int.Parse(Request["idutilizador"].ToString());

                Utilizadores tt = new Utilizadores();

                DataTable dados = tt.devolveDadosUt(idUtilizador);
                if (dados == null || dados.Rows.Count == 0)
                {
                    //o ut nao existe na tabela dos uts
                    throw new Exception("Ut não existe");
                }
                //Mostrar os Dados dos livros

                tbnome.Text = dados.Rows[0]["nome"].ToString();
                tbEmail.Text = dados.Rows[0]["email"].ToString();
                tbpassword.Text = dados.Rows[0]["password"].ToString();
                tbNascimento.Text = DateTime.Parse(dados.Rows[0]["data_nascimento"].ToString()).ToString("yyyy-MM-dd");
                tbCC.Text = dados.Rows[0]["cc"].ToString();
                tbnif.Text = dados.Rows[0]["nif"].ToString();
                ddnacionalidade.Text = dados.Rows[0]["nacionalidade"].ToString();
                tbtelefone.Text = dados.Rows[0]["telefone"].ToString();
                dpGenero.Text = dados.Rows[0]["genero"].ToString();
                dpPerfil.Text = dados.Rows[0]["perfil"].ToString();
                tbIdade.Text = dados.Rows[0]["idade"].ToString();
            }
            catch
            {
                lbErro.Text = "O ut indicado nao existe.";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Redirecionar", "returnMain('/Administrador/admin.aspx')", true);
            }

        }

        protected void btVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Utilizador/InserirUtilizador.aspx");
        }

        protected void btRegistar_Click(object sender, EventArgs e)
        {
            try
            {

                string Nome = tbnome.Text;
                string email = tbEmail.Text;
                string password = tbpassword.Text;
                DateTime data_nasc = DateTime.Parse(tbNascimento.Text);
                string cc = tbCC.Text;
                string nif = tbnif.Text;
                string nacionality = ddnacionalidade.SelectedValue;
                string telefone = tbtelefone.Text;
                string genero = dpGenero.SelectedValue;
                string perfil = dpPerfil.SelectedValue;
                string idade = tbIdade.Text;

                Utilizadores tt = new Utilizadores();

                int idutilizador = int.Parse(Request["idutilizador"].ToString());
                tt.nome = Nome;
                tt.email = email;
                tt.password = password;
                tt.dataNasc = data_nasc;
                tt.cc = cc;
                tt.nif = nif;
                tt.nacionalidade = int.Parse(nacionality);
                tt.telefone = telefone;
                tt.genero = int.Parse(genero);
                tt.perfil = int.Parse(perfil);
                tt.idade = int.Parse(idade);
                tt.idutilizador = idutilizador;

                tt.atualizarUT();

                lbErro.Text = "Atualizado com sucesso";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Redirecionar", "returnMain('InserirUtilizador.aspx')", true);



            }
            catch (Exception err)
            {
                lbErro.Text = "O ut indicado nao existe." + err.Message;
                Response.Redirect("~/Administrador/admin.aspx");
            }
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