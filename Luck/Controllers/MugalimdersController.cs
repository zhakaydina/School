using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Luck.Models;

namespace Luck.Controllers
{
    public class MugalimdersController : Controller
    {
        private Mektep_DBEntities db = new Mektep_DBEntities();

        // GET: Mugalimders
        public ActionResult Index()
        {
            return View(db.Mugalimder.ToList());
        }

        // GET: Mugalimders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mugalimder mugalimder = db.Mugalimder.Find(id);
            if (mugalimder == null)
            {
                return HttpNotFound();
            }
            return View(mugalimder);
        }

        // GET: Mugalimders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mugalimders/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_mugalim,Aty,Tegi,Akesinin_aty,Tel_nomeri,Tugan_kuni,Email,Meken_zhaiy")] Mugalimder mugalimder)
        {
            if (ModelState.IsValid)
            {
                db.Mugalimder.Add(mugalimder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mugalimder);
        }

        // GET: Mugalimders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mugalimder mugalimder = db.Mugalimder.Find(id);
            if (mugalimder == null)
            {
                return HttpNotFound();
            }
            return View(mugalimder);
        }

        // POST: Mugalimders/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_mugalim,Aty,Tegi,Akesinin_aty,Tel_nomeri,Tugan_kuni,Email,Meken_zhaiy")] Mugalimder mugalimder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mugalimder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mugalimder);
        }

        // GET: Mugalimders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mugalimder mugalimder = db.Mugalimder.Find(id);
            if (mugalimder == null)
            {
                return HttpNotFound();
            }
            return View(mugalimder);
        }

        // POST: Mugalimders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mugalimder mugalimder = db.Mugalimder.Find(id);
            db.Mugalimder.Remove(mugalimder);
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
