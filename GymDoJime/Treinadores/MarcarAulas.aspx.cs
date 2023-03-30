using GymDoJime.Classes;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymDoJime.Treinadores
{
    public partial class MarcarAulas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tbIDTreinador.Text = Session["idutilizador"].ToString();
        }
        private void LimparForm()
        {
            tbData.Text = "";
            dpAula.SelectedIndex = 0;
            dpSala.SelectedIndex = 0;
            dpTreino.SelectedIndex = 0;
            tbIDTreinador.Text = Session["idutilizador"].ToString();

        }
        protected void btMarcar_Click(object sender, EventArgs e)
        {
            string idtreinador = tbIDTreinador.Text;
            string sala = dpSala.SelectedItem.Text;
            string aula = dpAula.SelectedItem.Text;
            string Treino = dpTreino.SelectedItem.Text;
           
            DateTime datahora = DateTime.Parse(tbData.Text);






            marcacoes mar = new marcacoes();

            mar.dataHora = datahora;
            mar.sala = sala;
            mar.TipoTreino = Treino;
            mar.tipoAula = aula;
            mar.idtreinador = int.Parse(Session["idutilizador"].ToString()); 

            mar.InserirConsulta();




            LimparForm();


            lbErro.Text = "Registo feito com sucesso";
            ScriptManager.RegisterStartupScript(this, typeof(Page),
                "Redirecionar", "returnMain('TrainadorUser.aspx')", true);

            
                
        }

        

        protected void btVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TrainadorUser.aspx");
        }

        
        
    }
}