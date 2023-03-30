using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using GYMdoJime2_Modulo17E.Data;
using GYMdoJime2_Modulo17E.Migrations;

namespace GYMdoJime2_Modulo17E.Models
{
    [Authorize(Roles = "Administrador")]
    public class UtilizadoresController : Controller
    {
        private GYMdoJime2_Modulo17EContext db = new GYMdoJime2_Modulo17EContext();

        // GET: Utilizadores
        public ActionResult Index()
        {
            return View(db.Utilizadores.ToList());
        }

        // GET: Utilizadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilizadores utilizadores = db.Utilizadores.Find(id);
            if (utilizadores == null)
            {
                return HttpNotFound();
            }
            return View(utilizadores);
        }

        // GET: Utilizadores/Create
        public ActionResult Create()
        {
            var utilizador = new Utilizadores();
            utilizador.perfis = new[]
            {
                new SelectListItem{Value="0", Text = "Administrador"},
                new SelectListItem{Value="1", Text = "Treinador"},
                new SelectListItem{Value="2", Text="Utilizador"}
            };
            return View(utilizador);
           
        }

        // POST: Utilizadores/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDUtilizador,nome,email,idade,perfil")] Utilizadores utilizador)
        {
            
            utilizador.perfis = new[]
            {
                new SelectListItem{Value="0", Text = "Administrador"},
                new SelectListItem{Value="1", Text = "Treinador"},
                new SelectListItem{Value="2", Text="Utilizador"}
            };

            if (ModelState.IsValid)
            {
                //verificar se o nome  do utilizador ja existe
                var temp = db.Utilizadores.Where(u => u.nome == utilizador.nome).ToList();
                if (temp != null && temp.Count > 0)
                {
                    ModelState.AddModelError("Nome", "Ja existe com esse nome");
                    return View(utilizador);
                }
                // validar a password
                if (utilizador.email.Trim().Length < 3)
                {
                    ModelState.AddModelError("Email", "O email deve ser peenchido");
                    return View(utilizador);
                }
                

                db.Utilizadores.Add(utilizador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(utilizador);
        }

        // GET: Utilizadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilizadores utilizadores = db.Utilizadores.Find(id);
            if (utilizadores == null)
            {
                return HttpNotFound();
            }
            return View(utilizadores);
        }

        // POST: Utilizadores/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDUtilizador,nome,email,idade,perfil")] Utilizadores utilizadores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(utilizadores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(utilizadores);
        }

        // GET: Utilizadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Utilizadores utilizadores = db.Utilizadores.Find(id);
            if (utilizadores == null)
            {
                return HttpNotFound();
            }
            return View(utilizadores);
        }

        // POST: Utilizadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Utilizadores utilizadores = db.Utilizadores.Find(id);
            db.Utilizadores.Remove(utilizadores);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
