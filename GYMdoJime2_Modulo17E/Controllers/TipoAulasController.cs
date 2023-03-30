using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GYMdoJime2_Modulo17E.Data;
using GYMdoJime2_Modulo17E.Models;

namespace GYMdoJime2_Modulo17E.Controllers
{
    
    public class TipoAulasController : Controller
    {
        private GYMdoJime2_Modulo17EContext db = new GYMdoJime2_Modulo17EContext();

        [Authorize]
        // GET: TipoAulas
        public ActionResult Index()
        {
            return View(db.TipoAulas.ToList());
        }

        [Authorize]
        // GET: TipoAulas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoAula tipoAula = db.TipoAulas.Find(id);
            if (tipoAula == null)
            {
                return HttpNotFound();
            }
            return View(tipoAula);
        }

        [Authorize(Roles = "Administrador")]
        [Authorize(Roles = "Treinador")]
        // GET: TipoAulas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoAulas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador")]
        [Authorize(Roles = "Treinador")]
        public ActionResult Create([Bind(Include = "TipoAulaID,NomeAula")] TipoAula tipoAula)
        {   if(db.TipoAulas.Any(tp => tp.NomeAula == tipoAula.NomeAula))
            {
                ViewBag.ErrorMessage = "Já existe uma aula com este nome.";
                return View(tipoAula);
            }
            else
            {
                if (ModelState.IsValid)
                {
                    db.TipoAulas.Add(tipoAula);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            

            return View(tipoAula);
        }


        [Authorize(Roles = "Administrador")]
        [Authorize(Roles = "Treinador")]
        // GET: TipoAulas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoAula tipoAula = db.TipoAulas.Find(id);
            if (tipoAula == null)
            {
                return HttpNotFound();
            }
            return View(tipoAula);
        }

        // POST: TipoAulas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador")]
        [Authorize(Roles = "Treinador")]
        public ActionResult Edit([Bind(Include = "TipoAulaID,NomeAula")] TipoAula tipoAula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoAula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoAula);
        }


        [Authorize(Roles = "Administrador")]
        [Authorize(Roles = "Treinador")]
        // GET: TipoAulas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoAula tipoAula = db.TipoAulas.Find(id);
            if (tipoAula == null)
            {
                return HttpNotFound();
            }
            return View(tipoAula);
        }

        // POST: TipoAulas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador")]
        [Authorize(Roles = "Treinador")]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoAula tipoAula = db.TipoAulas.Find(id);
            db.TipoAulas.Remove(tipoAula);
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
