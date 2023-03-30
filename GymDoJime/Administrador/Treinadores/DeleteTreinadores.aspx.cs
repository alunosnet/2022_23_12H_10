 using GymDoJime.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymDoJime.Administrador.Treinadores
{
    public partial class DeleteTreinadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                //querystring treinador
                int idTreinador = int.Parse(Request["idtreinador"].ToString());

                Treinador tt = new Treinador();

                DataTable dados = tt.devolveDadosUt(idTreinador);
                if (dados == null || dados.Rows.Count == 0)
                {
                    throw new Exception("Treinador não existe");
                }

                //Mosttar dados do treinador
                tbnome.Text = dados.Rows[0]["nomeTreinador"].ToString();
                tbEmail.Text = dados.Rows[0]["emailTreinador"].ToString();
                tbpassword.Text = dados.Rows[0]["password"].ToString();
                
                tbCC.Text = dados.Rows[0]["ccTreinador"].ToString();
                tbnif.Text = dados.Rows[0]["nifTreinador"].ToString();
                


            }
            catch
            {
                lbErro.Text = "Treinador indicado nao existe.";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "redirecionar","returnMain('/Administrador/Treinadores/InserirTreinadores.aspx')", true);
            }
        }

        protected void btRemover_Click(object sender, EventArgs e)
        {
            try
            {
                int idTreinador = int.Parse(Request["idTreinador"].ToString());

                Treinador tt = new Treinador();

                tt.RemoverTreinador(idTreinador);

                lbErro.Text = "o Treinador foi removido com sucesso";
                ScriptManager.RegisterStartupScript(this, typeof(Page),"Redirecionar","returnMain('InserirTreinadores.aspx')", true);

            }
            catch
            {
                Response.Redirect("~/Administrador/Treinadores/InserirTreinadores.aspx");
            }
        }

        protected void btVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrador/Treinadores/InserirTreinadores.aspx");
        }
    }
}