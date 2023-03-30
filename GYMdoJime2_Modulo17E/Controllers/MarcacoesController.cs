using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using GYMdoJime2_Modulo17E.Data;
using GYMdoJime2_Modulo17E.Models;

namespace GYMdoJime2_Modulo17E.Controllers
{
    [Authorize]

    public class MarcacoesController : Controller
    {

        private GYMdoJime2_Modulo17EContext db = new GYMdoJime2_Modulo17EContext();

       
        // GET: Marcacoes
        public ActionResult Index(int? id)
        {
            var marcacoes = db.Marcacoes.Include(m => m.SalaID).Include(m => m.TipoAulaID).Include(m => m.TreinadoresID);
            if (id == null)
            {
                marcacoes = db.Marcacoes.Include(m => m.SalaID).Include(m => m.TipoAulaID).Include(m => m.TreinadoresID);
            }
            else
            {
                if(id == 1)
                {
                    marcacoes = db.Marcacoes.OrderBy(s => s.Sala).Include(m => m.SalaID).Include(m => m.TipoAulaID).Include(m => m.TreinadoresID);
                }else if(id == 4)
                {
                    marcacoes = db.Marcacoes.OrderBy(s => s.MarcacoesDataHora).Include(m => m.SalaID).Include(m => m.TipoAulaID).Include(m => m.TreinadoresID);
                }
                
            }
            
            return View(marcacoes.ToList());
        }

        [Authorize]
        // GET: Marcacoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marcacoes marcacoes = db.Marcacoes.Where(m=>m.MarcacoesID==id).Include(m => m.SalaID).Include(m => m.TipoAulaID).Include(m => m.TreinadoresID).First();
            if (marcacoes == null)
            {
                return HttpNotFound();
            }
            return View(marcacoes);
        }

        [Authorize(Roles = "Treinador")]
        // GET: Marcacoes/Create
        public ActionResult Create()
        {
            ViewBag.Sala = new SelectList(db.Salas.Where(s=>s.EstadoSala == true), "SalaID", "NomeSala");
            ViewBag.TipoAula = new SelectList(db.TipoAulas, "TipoAulaID", "NomeAula");
            ViewBag.Treinadores = new SelectList(db.Treinadores.Where(t=>t.TreinadoresEstado == true), "TreinadoresID", "TreinadoresName");
            return View();
        }


        [Authorize(Roles = "Treinador")]
        // POST: Marcacoes/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MarcacoesID,MarcacoesDataHora,Treinadores,Sala,TipoAula")] Marcacoes marcacoes)
        {
            if (ModelState.IsValid)
            {
                var estado = db.Salas.Find(marcacoes.Sala);
                estado.EstadoSala = false;
                db.Entry(estado).CurrentValues.SetValues(estado);

                var Testado = db.Treinadores.Find(marcacoes.Treinadores);
                Testado.TreinadoresEstado = false;
                db.Entry(Testado).CurrentValues.SetValues(Testado);

                db.Marcacoes.Add(marcacoes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Sala = new SelectList(db.Salas, "SalaID", "NomeSala", marcacoes.Sala);
            ViewBag.TipoAula = new SelectList(db.TipoAulas, "TipoAulaID", "NomeAula", marcacoes.TipoAula);
            ViewBag.Treinadores = new SelectList(db.Treinadores, "TreinadoresID", "TreinadoresName", marcacoes.Treinadores);
            return View(marcacoes);
        }

        [Authorize(Roles = "Treinador")]
        // GET: Marcacoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marcacoes marcacoes = db.Marcacoes.Find(id);
            if (marcacoes == null)
            {
                return HttpNotFound();
            }
            ViewBag.Sala = new SelectList(db.Salas, "SalaID", "NomeSala", marcacoes.Sala);
            ViewBag.TipoAula = new SelectList(db.TipoAulas, "TipoAulaID", "NomeAula", marcacoes.TipoAula);
            ViewBag.Treinadores = new SelectList(db.Treinadores, "TreinadoresID", "TreinadoresName", marcacoes.Treinadores);
            return View(marcacoes);
        }

        [Authorize(Roles = "Treinador")]
        // POST: Marcacoes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MarcacoesID,MarcacoesDataHora,Treinadores,Sala,TipoAula")] Marcacoes marcacoes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marcacoes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Sala = new SelectList(db.Salas, "SalaID", "NomeSala", marcacoes.Sala);
            ViewBag.TipoAula = new SelectList(db.TipoAulas, "TipoAulaID", "NomeAula", marcacoes.TipoAula);
            ViewBag.Treinadores = new SelectList(db.Treinadores, "TreinadoresID", "TreinadoresName", marcacoes.Treinadores);
            return View(marcacoes);
        }

        [Authorize(Roles = "Treinador")]
        // GET: Marcacoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marcacoes marcacoes = db.Marcacoes.Find(id);
            if (marcacoes == null)
            {
                return HttpNotFound();
            }
            return View(marcacoes);
        }

        // POST: Marcacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Marcacoes marcacoes = db.Marcacoes.Find(id);
            db.Marcacoes.Remove(marcacoes);
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


        public ActionResult PesquisaDinamica()
        {
            return View();
        }
    }
}
