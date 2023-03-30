using GymDoJime.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymDoJime.Treinadores
{
    public partial class DeleteAula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                int idmarcacao = int.Parse(Request["idmarcacao"].ToString());

                marcacoes tt = new marcacoes();

                DataTable dados = tt.ListaTodasMarcacoes(idmarcacao);
                if (dados == null || dados.Rows.Count == 0)
                {
                    throw new Exception("Treinador não existe");
                }

                //Mosttar dados do treinador
                tbData.Text = DateTime.Parse(dados.Rows[0]["data_hora"].ToString()).ToString("yyyy-MM-dd");
                dpSala.SelectedItem.Text = dados.Rows[0]["sala"].ToString();
                dpTreino.SelectedItem.Text = dados.Rows[0]["tipo_de_treino"].ToString();
                dpAula.SelectedItem.Text = dados.Rows[0]["tipo_de_aula"].ToString();
                TextBox1.Text = dados.Rows[0]["idmarcacao"].ToString();






            }
            catch
            {
                lbErro.Text = "Aula indicado nao existe.";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "redirecionar", "returnMain('/Treinadores/TrainadorUser.aspx')", true);
            }
        }

        protected void btDesmarcar_Click(object sender, EventArgs e)
        {
            try
            {
                int idmarcacao = int.Parse(Request["idmarcacao"].ToString());

                marcacoes tt = new marcacoes();

                tt.DeleteAulas(idmarcacao);

                lbErro.Text = "A aula foi desmarcada com sucesso";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Redirecionar", "returnMain('/Treinadores/TrainadorUser.aspx')", true);

            }
            catch
            {
                Response.Redirect("~/Treinadores/TrainadorUser.aspx");
            }
        }

        protected void btVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Treinadores/TrainadorUser.aspx");
        }
    }
}