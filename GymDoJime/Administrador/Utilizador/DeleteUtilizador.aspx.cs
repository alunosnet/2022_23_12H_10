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
    public partial class DeleteUtilizador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //querystring Utilizador
                int idUtilizador = int.Parse(Request["idutilizador"].ToString());

                Utilizadores tt = new Utilizadores();

                DataTable dados = tt.devolveDadosUt(idUtilizador);
                if (dados == null || dados.Rows.Count == 0)
                {
                    throw new Exception("Utilizador não existe");
                }

                //Mosttar dados do treinador
                tbnome.Text = dados.Rows[0]["nome"].ToString();
                tbEmail.Text = dados.Rows[0]["email"].ToString();
                tbpassword.Text = dados.Rows[0]["password"].ToString();

                tbCC.Text = dados.Rows[0]["cc"].ToString();
                tbnif.Text = dados.Rows[0]["nif"].ToString();



            }
            catch
            {
                lbErro.Text = "Utilizador indicado nao existe.";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "redirecionar", "returnMain('/Administrador/Utilizador/InserirUtilizador.aspx')", true);
            }
        }

        protected void btRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int idUtilizador = int.Parse(Request["idutilizador"].ToString());

                Utilizadores ut = new Utilizadores();

                ut.RemoverTreinador(idUtilizador);

                lbErro.Text = "O Utilizador foi removido com sucesso";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Redirecionar", "returnMain('InserirUtilizador.aspx')", true);

            }
            catch
            {
                Response.Redirect("~/Administrador/Utilizador/InserirUtilizador.aspx");
            }
        }

        protected void btVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrador/Utilizador/InserirUtilizador.aspx");
        }
    }
}