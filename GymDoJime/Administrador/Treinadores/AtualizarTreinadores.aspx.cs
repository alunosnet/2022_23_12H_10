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
    public partial class AtualizarTreinadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                return;
            }
            try
            {
                int idTreinador = int.Parse(Request["idtreinador"].ToString());

                Treinador tt = new Treinador();

                DataTable dados = tt.devolveDadosUt(idTreinador);
                if (dados == null || dados.Rows.Count == 0)
                {
                    //o ut nao existe na tabela dos uts
                    throw new Exception("Ut não existe");
                }
                //Mostrar os Dados dos livros

                tbnome.Text = dados.Rows[0]["nomeTreinador"].ToString();
                tbEmail.Text = dados.Rows[0]["emailTreinador"].ToString();
                tbpassword.Text = dados.Rows[0]["password"].ToString();
                tbNascimento.Text = DateTime.Parse(dados.Rows[0]["data_nasc"].ToString()).ToString("yyyy-MM-dd");
                tbCC.Text = dados.Rows[0]["ccTreinador"].ToString();
                tbnif.Text = dados.Rows[0]["nifTreinador"].ToString();
                ddnacionalidade.Text = dados.Rows[0]["nacionality"].ToString();
                tbtelefone.Text = dados.Rows[0]["telefoneTreinador"].ToString();
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

                Treinador tt = new Treinador();

                int idtreinador = int.Parse(Request["idtreinador"].ToString());
                tt.nome = Nome;
                tt.email = email;
                tt.password = password;
                tt.dataNasc = data_nasc;
                tt.cc = cc;
                tt.nif = nif;
                tt.nacionalidade = nacionality;
                tt.telefone = telefone;
                tt.genero = genero;
                tt.perfil = perfil;
                tt.idade = int.Parse(idade);
                tt.idtreinador = idtreinador;

                tt.atualizarTT();

                lbErro.Text = "Atualizado com sucesso";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "Redirecionar", "returnMain('InserirTreinadores.aspx')", true);
                
                

            }
            catch(Exception err)
            {
                lbErro.Text = "O ut indicado nao existe." + err.Message;
                Response.Redirect("~/Administrador/admin.aspx");
            }
            

        }

        protected void btVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrador/admin.aspx");
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