using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Viva.FacOnLine.Models;

namespace Viva.FacOnLine.Controllers
{
    public class FichaAtendimentoController : Controller
    {
        private FichaAtendimentoContext db = new FichaAtendimentoContext();

        //
        // GET: /FichaAtendimento/

        public ActionResult Index()
        {
            return View(db.FichaAtendimentoModels.ToList());
        }

        //
        // GET: /FichaAtendimento/Details/5

        public ActionResult Details(int id = 0)
        {
            FichaAtendimentoModel fichaatendimentomodel = db.FichaAtendimentoModels.Find(id);
            if (fichaatendimentomodel == null)
            {
                return HttpNotFound();
            }
            return View(fichaatendimentomodel);
        }

        //
        // GET: /FichaAtendimento/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FichaAtendimento/Create

        [HttpPost]
        public ActionResult Create(FichaAtendimentoModel fichaatendimentomodel)
        {
            if (ModelState.IsValid)
            {
                db.FichaAtendimentoModels.Add(fichaatendimentomodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fichaatendimentomodel);
        }

        //
        // GET: /FichaAtendimento/Edit/5

        public ActionResult Edit(int id = 0)
        {
            FichaAtendimentoModel fichaatendimentomodel = db.FichaAtendimentoModels.Find(id);
            if (fichaatendimentomodel == null)
            {
                return HttpNotFound();
            }
            return View(fichaatendimentomodel);
        }

        //
        // POST: /FichaAtendimento/Edit/5

        [HttpPost]
        public ActionResult Edit(FichaAtendimentoModel fichaatendimentomodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fichaatendimentomodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fichaatendimentomodel);
        }

        //
        // GET: /FichaAtendimento/Delete/5

        public ActionResult Delete(int id = 0)
        {
            FichaAtendimentoModel fichaatendimentomodel = db.FichaAtendimentoModels.Find(id);
            if (fichaatendimentomodel == null)
            {
                return HttpNotFound();
            }
            return View(fichaatendimentomodel);
        }

        //
        // POST: /FichaAtendimento/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            FichaAtendimentoModel fichaatendimentomodel = db.FichaAtendimentoModels.Find(id);
            db.FichaAtendimentoModels.Remove(fichaatendimentomodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}