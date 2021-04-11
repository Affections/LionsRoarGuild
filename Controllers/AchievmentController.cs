using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LionsRoarGuild;
using LionsRoarGuild.Models;

namespace LionsRoarGuild.Controllers
{
    public class AchievmentController : Controller
    {
        private LionsRoarContext db = new LionsRoarContext();

        // GET: Achievments
        public ActionResult Index()
        {
            return View(db.Achievments.ToList());
        }

        // GET: Achievments/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Achievment achievment = db.Achievments.Find(id);
            if (achievment == null)
            {
                return HttpNotFound();
            }
            return View(achievment);
        }

        // GET: Achievments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Achievments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nickname,Description")] Achievment achievment)
        {
            if (ModelState.IsValid)
            {
                db.Achievments.Add(achievment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(achievment);
        }

        // GET: Achievments/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Achievment achievment = db.Achievments.Find(id);
            if (achievment == null)
            {
                return HttpNotFound();
            }
            return View(achievment);
        }

        // POST: Achievments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nickname,Description")] Achievment achievment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(achievment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(achievment);
        }

        // GET: Achievments/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Achievment achievment = db.Achievments.Find(id);
            if (achievment == null)
            {
                return HttpNotFound();
            }
            return View(achievment);
        }

        // POST: Achievments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Achievment achievment = db.Achievments.Find(id);
            db.Achievments.Remove(achievment);
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
