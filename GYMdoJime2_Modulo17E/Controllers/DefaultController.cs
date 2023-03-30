using GYMdoJime2_Modulo17E.Data;
using GYMdoJime2_Modulo17E.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace GYMdoJime2_Modulo17E.Controllers
{
    public class DefaultController : Controller
    {
        private GYMdoJime2_Modulo17EContext db = new GYMdoJime2_Modulo17EContext();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Utilizadores utilizador)
        {
            if (utilizador.nome != null && utilizador.email != null)
            {
                foreach (var u in db.Utilizadores.ToList())
                {
                    if (u.nome == utilizador.nome && u.email == utilizador.email)
                    {
                        //Inciar sessao
                        FormsAuthentication.SetAuthCookie(utilizador.nome, false);
                        //redirecionar
                        if (Request.QueryString["ReturnUrl"] == null)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            return Redirect(Request.QueryString["ReturnUrl"].ToString());
                        }



                    }
                }
            }

            ModelState.AddModelError("", "Login falhou Tente novamente");
            return View(utilizador);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}