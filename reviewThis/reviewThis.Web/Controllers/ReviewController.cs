using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reviewThis.Model;
using reviewThis.DataLayer;
using reviewThis.Web.ViewModel;

namespace reviewThis.Web.Controllers
{
    public class ReviewController : Controller
    {
        private ReviewsContext db;


        public ReviewController()
        {
            db = new ReviewsContext();
        }
        //
        // GET: /Review/

        public ActionResult Index()
        {
            return View(db.ReviewEntity.ToList());
        }

        //
        // GET: /Review/Details/5

        public ActionResult Details(int id = 0)
        {
            ToReviewEntity toreviewentity = db.ReviewEntity.Find(id);
            if (toreviewentity == null)
            {
                return HttpNotFound();
            }
            ToReviewEntityVM _vm = new ToReviewEntityVM();
            _vm.Link = toreviewentity.Link;
            _vm.Description = toreviewentity.Description;
            _vm.Name = toreviewentity.Name;
            _vm.ToReviewEntityID = toreviewentity.ToReviewEntityID;
            _vm.MsgToClient = "Reviews ...";

            return View(_vm);
        }

        //
        // GET: /Review/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Review/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ToReviewEntity toreviewentity)
        {
            if (ModelState.IsValid)
            {
                db.ReviewEntity.Add(toreviewentity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(toreviewentity);
        }

        //
        // GET: /Review/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ToReviewEntity toreviewentity = db.ReviewEntity.Find(id);
            if (toreviewentity == null)
            {
                return HttpNotFound();
            }
            return View(toreviewentity);
        }

        //
        // POST: /Review/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ToReviewEntity toreviewentity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(toreviewentity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(toreviewentity);
        }

        //
        // GET: /Review/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ToReviewEntity toreviewentity = db.ReviewEntity.Find(id);
            if (toreviewentity == null)
            {
                return HttpNotFound();
            }
            return View(toreviewentity);
        }

        //
        // POST: /Review/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ToReviewEntity toreviewentity = db.ReviewEntity.Find(id);
            db.ReviewEntity.Remove(toreviewentity);
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