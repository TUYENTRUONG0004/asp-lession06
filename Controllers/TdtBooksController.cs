using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tdtlession06CF.Models;

namespace Tdtlession06CF.Controllers
{
    public class TdtBooksController : Controller
    {
        private TdtBookStore db = new TdtBookStore();

        // GET: TdtBooks
        public ActionResult Index()
        {
            return View(db.Books.ToList());
        }

        // GET: TdtBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtBook tdtBook = db.Books.Find(id);
            if (tdtBook == null)
            {
                return HttpNotFound();
            }
            return View(tdtBook);
        }

        // GET: TdtBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TdtBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TdtId,TdtBookId,TtdTitle,TdtAuthor,TdtYear,TdtPublisher,TdtPicture,TdtCategoryId")] TdtBook tdtBook)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(tdtBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tdtBook);
        }

        // GET: TdtBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtBook tdtBook = db.Books.Find(id);
            if (tdtBook == null)
            {
                return HttpNotFound();
            }
            return View(tdtBook);
        }

        // POST: TdtBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TdtId,TdtBookId,TtdTitle,TdtAuthor,TdtYear,TdtPublisher,TdtPicture,TdtCategoryId")] TdtBook tdtBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tdtBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tdtBook);
        }

        // GET: TdtBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtBook tdtBook = db.Books.Find(id);
            if (tdtBook == null)
            {
                return HttpNotFound();
            }
            return View(tdtBook);
        }

        // POST: TdtBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TdtBook tdtBook = db.Books.Find(id);
            db.Books.Remove(tdtBook);
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
