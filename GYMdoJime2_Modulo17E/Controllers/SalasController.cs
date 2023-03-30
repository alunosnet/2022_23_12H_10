using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using GYMdoJime2_Modulo17E.Data;
using GYMdoJime2_Modulo17E.Models;

namespace GYMdoJime2_Modulo17E.Controllers
{
   
    public class SalasController : Controller
    {
        private GYMdoJime2_Modulo17EContext db = new GYMdoJime2_Modulo17EContext();

        // GET: Salas
        [Authorize]
        public ActionResult Index(int? id)
        {
            var salas = db.Salas.ToList();
            if (id == null)
            {
                salas = db.Salas.ToList();
            }else if (id == 1)
            {
                salas = db.Salas.ToList().OrderBy(s => int.Parse(Regex.Replace(s.NomeSala, "[^0-9]+", ""))).ToList();
            }

            return View(salas.ToList());
        }
        [Authorize]
        // GET: Salas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salas salas = db.Salas.Find(id);
            if (salas == null)
            {
                return HttpNotFound();
            }
            ViewBag.utilizacoes = db.Marcacoes.Where(s => s.Sala == id).ToList().Count;
            return View(salas);
        }

        [Authorize(Roles = "Administrador")]
        [Authorize(Roles = "Treinador")]
        // GET: Salas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salas/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador")]
        [Authorize(Roles = "Treinador")]
        public ActionResult Create([Bind(Include = "SalaID,NomeSala")] Salas salas)
        {
            string numerosala = Regex.Match(salas.NomeSala, @"\d+").Value;
            int numeroSalaInt = int.Parse(numerosala); 
            if (db.Salas.Any(s => s.NomeSala == salas.NomeSala ))
            {
                ViewBag.ErrorMessage = "Já existe uma sala com este nome.";
                return View(salas);
            }else if(numeroSalaInt < 0)
            {
                ViewBag.ErrorMessage = "o nmero da sala tem de ser maior que zero e nao pode existir na base de dados";
                return View(salas);
            }
            else
            {
                if (ModelState.IsValid)
                {

                    db.Salas.Add(salas);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            

            return View(salas);
        }

        [Authorize(Roles = "Administrador")]
        [Authorize(Roles = "Treinador")]
        // GET: Salas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salas salas = db.Salas.Find(id);
            if (salas == null)
            {
                return HttpNotFound();
            }
            return View(salas);
        }

        // POST: Salas/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador")]
        [Authorize(Roles = "Treinador")]
        public ActionResult Edit([Bind(Include = "SalaID,NomeSala")] Salas salas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salas);
        }

        // GET: Salas/Delete/5
        [Authorize(Roles = "Administrador")]
        [Authorize(Roles = "Treinador")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salas salas = db.Salas.Find(id);
            if (salas == null)
            {
                return HttpNotFound();
            }
            return View(salas);
        }

        // POST: Salas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Salas salas = db.Salas.Find(id);
            db.Salas.Remove(salas);
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
