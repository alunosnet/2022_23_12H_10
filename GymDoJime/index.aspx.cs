using GymDoJime.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymDoJime
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["perfil"] != null)
            {
                divLogin.Visible = false;
            }
        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tbEmail.Text;
                string password = tbpassword.Text;
                UserLogin user = new UserLogin();
                DataTable dados = user.VerificarLogin(email, password);
                if (dados == null)
                {
                    throw new Exception("Login falhou");
                }
                else if (dados != null)
                {
                    //variaveis de sessao
                    Session["nome"] = dados.Rows[0]["nome"].ToString();
                    Session["idutilizador"] = dados.Rows[0]["id"].ToString();
                    //autorização
                    Session["perfil"] = dados.Rows[0]["perfil"].ToString();
                    Session["ip"] = Request.UserHostAddress;
                    Session["useragent"] = Request.UserAgent;
                    //Redirecionar
                    if (Session["perfil"].ToString() == "0")
                        Response.Redirect("~/Administrador/admin.aspx");
                    if (Session["perfil"].ToString() == "1")
                        Response.Redirect("~/User/User.aspx");
                    if (Session["perfil"].ToString() == "2")
                        Response.Redirect("~/Treinadores/TrainadorUser.aspx");
                }





                   
                
                    


                
                
            }
            catch
            {
                lbErro.Text = "Login falhou.Tente novamente";
            }
        }

        protected void btRecuperar_Click(object sender, EventArgs e)
        {

        }

        protected void btnRegistar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/registo.aspx");

        }
    }
}