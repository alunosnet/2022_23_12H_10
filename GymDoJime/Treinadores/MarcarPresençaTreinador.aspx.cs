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
    public partial class MarcarPresençaTreinador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (IsPostBack)
            {
                return;
            }

            AtualizarDDUtilizadores();
            AtualizarDDAulas();

        }

        private void AtualizarDDUtilizadores()
        {
            Utilizadores u = new Utilizadores();
            dputilizadores.Items.Clear();
            DataTable dados = u.ListaTodosLivros();
            foreach (DataRow linha in dados.Rows)
            {
                dputilizadores.Items.Add(
                    new ListItem(linha["nome"].ToString(),linha["idutilizador"].ToString()));

            }
        }
        private void AtualizarDDAulas()
        {
            marcacoes u = new marcacoes();
            dpAulas.Items.Clear();
            DataTable dados = u.ListaTodasMarcacao();
            foreach (DataRow linha in dados.Rows)
            {
                dpAulas.Items.Add(
                    new ListItem(DateTime.Parse(linha["data_hora"].ToString()).ToString("yyyy-MM-dd"),linha["idmarcacao"].ToString()));

            }
        }

        protected void btMarcar_Click(object sender, EventArgs e)
        {

            try
            {
                int idmarcacao = int.Parse(dpAulas.SelectedItem.Value);
                int idutilizador = int.Parse(dpAulas.SelectedItem.Value);
                bool presença = chPresença.Checked;

                Presenças p = new Presenças();

                p.idmarcacao = idmarcacao;
                p.idutilizador = idutilizador;
                p.presenças = presença;

                p.InserirPresença();
                lbErro.Text = "Presença marcada com sucesso";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "Redirecionar", "returnMain('TrainadorUser.aspx')", true);

            }
            catch(Exception err)
            {
                lbErro.Text = err.Message;
            }
            




            
        }
    }
}