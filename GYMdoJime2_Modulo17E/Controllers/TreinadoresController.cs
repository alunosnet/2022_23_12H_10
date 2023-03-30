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
    [Authorize(Roles = "Administrador")]
    public class TreinadoresController : Controller
    {
        private GYMdoJime2_Modulo17EContext db = new GYMdoJime2_Modulo17EContext();

        // GET: Treinadores
        public ActionResult Index(int? id)
        {
            var treinadores = db.Treinadores.ToList();
            if (id == null)
            {
                treinadores = db.Treinadores.ToList();
            }
            else if (id == 2)
            {
                treinadores = db.Treinadores.OrderBy(t => t.TreinadoresIdade).ToList();
            }
            return View(treinadores.ToList());
        }

        // GET: Treinadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treinadores treinadores = db.Treinadores.Find(id);
            if (treinadores == null)
            {
                return HttpNotFound();
            }
            return View(treinadores);
        }

        // GET: Treinadores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Treinadores/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TreinadoresID,TreinadoresName,TreinadoresIdade,TreinadoresEmail,TreinadoresTelefone")] Treinadores treinadores)
        {
            if (ModelState.IsValid)
            {
                
                db.Treinadores.Add(treinadores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(treinadores);
        }

        // GET: Treinadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treinadores treinadores = db.Treinadores.Find(id);
            if (treinadores == null)
            {
                return HttpNotFound();
            }
            return View(treinadores);
        }

        // POST: Treinadores/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TreinadoresID,TreinadoresName,TreinadoresIdade,TreinadoresEmail,TreinadoresTelefone")] Treinadores treinadores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(treinadores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(treinadores);
        }

        // GET: Treinadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treinadores treinadores = db.Treinadores.Find(id);
            if (treinadores == null)
            {
                return HttpNotFound();
            }
            return View(treinadores);
        }

        // POST: Treinadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Treinadores treinadores = db.Treinadores.Find(id);
            db.Treinadores.Remove(treinadores);
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
