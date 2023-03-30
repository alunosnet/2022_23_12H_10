using GYMdoJime2_Modulo17E.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYMdoJime2_Modulo17E.Controllers
{
    [Authorize(Roles ="Administrador")]
    public class ConsultasController : Controller
    {
        private GYMdoJime2_Modulo17EContext db = new GYMdoJime2_Modulo17EContext();
        // GET: Consultas
        public ActionResult Index()
        {
            return View();
        }
        [ActionName("Index")]
        [HttpPost]
        public ActionResult PesquisaCliente()
        {

            string nome = Request.Form["tbNome"];
            var clientes = db.Utilizadores.Where(c => c.nome.Contains(nome));
            return View("PesquisarPorNome", clientes.ToList());
        }
        public ActionResult PesquisaDinamica()
        {
            return View();
        }
        public JsonResult PesquisaNome(string nome)
        {
            var clientes = db.Utilizadores.Where(c => c.nome.Contains(nome)).ToList();
            var lista = new List<Campos>();
            foreach (var c in clientes)
                lista.Add(new Campos() { nome = c.nome });
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public class Campos
        {
            public string nome { get; set; }

        }
    }
}