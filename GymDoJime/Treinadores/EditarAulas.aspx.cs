using GymDoJime.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymDoJime.Treinadores
{
    public partial class EditarAulas : System.Web.UI.Page
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

                //Mosttar dados do da ala
                tbData.Text = DateTime.Parse(dados.Rows[0]["data_hora"].ToString()).ToString("yyyy-MM-dd");
                dpSala.SelectedItem.Text = dados.Rows[0]["sala"].ToString();
                dpTreino.SelectedItem.Text = dados.Rows[0]["tipo_de_treino"].ToString();
                dpAula.SelectedItem.Text = dados.Rows[0]["tipo_de_aula"].ToString();
                tbIDTreinador.Text = dados.Rows[0]["idmarcacao"].ToString();







            }
            catch
            {
                lbErro.Text = "Aula indicado nao existe.";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "redirecionar", "returnMain('/Treinadores/TrainadorUser.aspx')", true);
            }
        }

        protected void btMarcar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string dataHora = tbData.Text;
                string sala = dpSala.SelectedItem.Text;
                string tipotreino = dpTreino.SelectedItem.Text;
                string tipoaula = dpAula.SelectedItem.Text;
                int idtreinador = int.Parse(Request["idtreinador"].ToString());

                marcacoes mt = new marcacoes();
                
                int idmarcacao = int.Parse(Request["idmarcacao"].ToString());
                mt.dataHora = DateTime.Parse(dataHora);
                mt.sala = sala;
                mt.tipoAula = tipoaula;
                mt.TipoTreino = tipotreino;
                mt.idmarcacao = idmarcacao;
                mt.idtreinador = idtreinador;

                mt.atualizarTT();


                lbErro.Text = "Atualizado com sucesso";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Redirecionar", "returnMain('TrainadorUser.aspx')", true);





            }
            catch (Exception err)
            {
                lbErro.Text = "O ut indicado nao existe." + err.Message;
                //Response.Redirect("~/erros.aspx");
            }
        }

        protected void btVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}