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
    
    public class InscricoesController : Controller
    {
        
        private GYMdoJime2_Modulo17EContext db = new GYMdoJime2_Modulo17EContext();

        // GET: Inscricoes
        public ActionResult Index()
        {
            var inscricoes = db.Inscricoes.Include(i => i.IDUtilizador).Include(i => i.MarcacoesID).Include(t => t.MarcacoesID.TreinadoresID);
            return View(inscricoes.ToList());
        }

        // GET: Inscricoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscricoes inscricoes = db.Inscricoes.Find(id);
            if (inscricoes == null)
            {
                return HttpNotFound();
            }

            var ut = db.Utilizadores.Find(inscricoes.idutilizadores);
            var marcacoes = db.Marcacoes.Find(inscricoes.idmarcacoes);
            var tr = db.Treinadores.Find(marcacoes.Treinadores);
            marcacoes.TreinadoresID = tr;
            inscricoes.MarcacoesID = marcacoes;
            inscricoes.IDUtilizador = ut;

            return View(inscricoes);
        }

        // GET: Inscricoes/Create
        [Authorize(Roles ="Utilizador")]
        public ActionResult Create()
        {
            int id = db.Utilizadores.Where(u => u.nome == User.Identity.Name).FirstOrDefault().IDUtilizador;

            ViewBag.idutilizadores = new SelectList(db.Utilizadores.Where(u => u.IDUtilizador == id), "IDUtilizador", "nome");
            ViewBag.idmarcacoes = new SelectList(db.Marcacoes, "MarcacoesID", "MarcacoesID");
            return View();
        }

        // POST: Inscricoes/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Utilizador")]
        public ActionResult Create([Bind(Include = "IdInscricoes,idutilizadores,idmarcacoes")] Inscricoes inscricoes)
        {
            if (ModelState.IsValid)
            {
                db.Inscricoes.Add(inscricoes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idutilizadores = new SelectList(db.Utilizadores, "IDUtilizador", "nome", inscricoes.idutilizadores);
            ViewBag.idmarcacoes = new SelectList(db.Marcacoes, "MarcacoesID", "MarcacoesID", inscricoes.idmarcacoes);
            return View(inscricoes);
        }

        // GET: Inscricoes/Edit/5
        [Authorize(Roles ="Administrador")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscricoes inscricoes = db.Inscricoes.Find(id);
            if (inscricoes == null)
            {
                return HttpNotFound();
            }
            ViewBag.idutilizadores = new SelectList(db.Utilizadores, "IDUtilizador", "nome", inscricoes.idutilizadores);
            ViewBag.idmarcacoes = new SelectList(db.Marcacoes, "MarcacoesID", "MarcacoesID", inscricoes.idmarcacoes);
            return View(inscricoes);
        }

        // POST: Inscricoes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador")]
        public ActionResult Edit([Bind(Include = "IdInscricoes,idutilizadores,idmarcacoes")] Inscricoes inscricoes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inscricoes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idutilizadores = new SelectList(db.Utilizadores, "IDUtilizador", "nome", inscricoes.idutilizadores);
            ViewBag.idmarcacoes = new SelectList(db.Marcacoes, "MarcacoesID", "MarcacoesID", inscricoes.idmarcacoes);
            return View(inscricoes);
        }

        [Authorize(Roles = "Administrador")]
        // GET: Inscricoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscricoes inscricoes = db.Inscricoes.Find(id);
            if (inscricoes == null)
            {
                return HttpNotFound();
            }
            return View(inscricoes);
        }

        [Authorize(Roles = "Administrador")]
        // POST: Inscricoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inscricoes inscricoes = db.Inscricoes.Find(id);
            db.Inscricoes.Remove(inscricoes);
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
