using GymDoJime.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymDoJime.Treinadores
{
    public partial class TrainadorUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConfigurarGridAulas();

            if (!IsPostBack)
            {
                AtualizaGrelhaAulas();
                
            }
            
            
            

            
        }

        private void ConfigurarGridAulas()
        {
            dgvAulasMarcadas.AllowPaging = true;
            dgvAulasMarcadas.PageSize = 5;
            dgvAulasMarcadas.PageIndexChanging += DgvAulasMarcadas_PageIndexChanging;
        }

        private void DgvAulasMarcadas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvAulasMarcadas.PageIndex = e.NewPageIndex;
            AtualizaGrelhaAulas();

        }

        private void AtualizaGrelhaAulas()
        {
            dgvAulasMarcadas.Columns.Clear();
            marcacoes mm = new marcacoes();
            DataTable dados = mm.ListaTodasMarcacoes();

            DataColumn dcEditar = new DataColumn();
            dcEditar.ColumnName = "Editar";
            dcEditar.DataType = Type.GetType("System.String");
            dados.Columns.Add(dcEditar);

            DataColumn dcApagar = new DataColumn();
            dcApagar.ColumnName = "Apagar";
            dcApagar.DataType = Type.GetType("System.String");
            dados.Columns.Add(dcApagar);

            DataColumn desmarcarAula = new DataColumn();
            desmarcarAula.ColumnName = "Desmarcar Aula";
            desmarcarAula.DataType = Type.GetType("System.String");
            dados.Columns.Add(desmarcarAula);


            //Colunas da data grid view
            dgvAulasMarcadas.DataSource = dados;
            dgvAulasMarcadas.AutoGenerateColumns = false;


            //Editar
            HyperLinkField hlEditar = new HyperLinkField();
            hlEditar.HeaderText = "Editar";
            hlEditar.DataTextField = "Editar";
            hlEditar.Text = "Editar...";
            hlEditar.DataNavigateUrlFormatString = "EditarAulas.aspx?idmarcacao={0}";
            hlEditar.DataNavigateUrlFields = new string[] { "idmarcacao" };
            dgvAulasMarcadas.Columns.Add(hlEditar);


            //Apagar
            HyperLinkField hlApagar = new HyperLinkField();
            hlApagar.HeaderText = "Desmarcar Aula";
            hlApagar.DataTextField = "Desmarcar Aula";
            hlApagar.Text = "Desmarcar...";
            hlApagar.DataNavigateUrlFormatString = "DeleteAula.aspx?idmarcacao={0}";
            hlApagar.DataNavigateUrlFields = new string[] { "idmarcacao" };
            dgvAulasMarcadas.Columns.Add(hlApagar);


            //idMarcacao
            BoundField bfnMarcacao = new BoundField();
            bfnMarcacao.HeaderText = "Id Aula";
            bfnMarcacao.DataField = "idmarcacao";
            dgvAulasMarcadas.Columns.Add(bfnMarcacao);


            //Data Hora
            BoundField bfnDataAula = new BoundField();
            bfnDataAula.HeaderText = "Data da Marcacao";
            bfnDataAula.DataField = "data_hora";
            bfnDataAula.DataFormatString = "{0:dd-MM-yyyy}";
            dgvAulasMarcadas.Columns.Add(bfnDataAula);


            //Sala
            BoundField bfnSala = new BoundField();
            bfnSala.HeaderText = "Sala";
            bfnSala.DataField = "sala";
            dgvAulasMarcadas.Columns.Add(bfnSala);


            //Tipo de treino
            BoundField bfnTipoTreino = new BoundField();
            bfnTipoTreino.HeaderText = "Tipo de treino";
            bfnTipoTreino.DataField = "tipo_de_treino";
            dgvAulasMarcadas.Columns.Add(bfnTipoTreino);


            //Tipo_de_aula
            BoundField bfnTipoAula = new BoundField();
            bfnTipoAula.HeaderText = "Tipo de aula";
            bfnTipoAula.DataField = "tipo_de_aula";
            dgvAulasMarcadas.Columns.Add(bfnTipoAula);


            //IdTreinador
            BoundField bnfIDTreinador = new BoundField();
            bnfIDTreinador.HeaderText = "ID do monstro";
            bnfIDTreinador.DataField = "idtreinador";
            dgvAulasMarcadas.Columns.Add(bnfIDTreinador);


            dgvAulasMarcadas.DataBind();





        }

       
        

        

        

        protected void btMarcar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MarcarAulas.aspx");
        }

        protected void btnPresenca_Click(object sender, EventArgs e)
        {
            Response.Redirect("MarcarPresençaTreinador.aspx");
        }
    }
}