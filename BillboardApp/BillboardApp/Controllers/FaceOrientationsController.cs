using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BillboardApp.DAL;
using BillboardApp.Models;
using X.PagedList;
using BillboardApp.ViewModels;

namespace BillboardApp.Controllers
{
    public class FaceOrientationsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: FaceOrientations
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.OrientationSortParm = String.IsNullOrEmpty(sortOrder) ? "Orientation_desc" : "";

            IQueryable<FaceOrientationViewModel> faceOrientationsData = from faceOrientations in db.FaceOrientations
                                                                   select new FaceOrientationViewModel()
                                                            {
                                                                FaceOrientationID = faceOrientations.FaceOrientationID,
                                                                Orientation = faceOrientations.Orientation
                                                            };
            //Paging
            if (searchString != null)
            {
                page = 1;
            }
            else { searchString = currentFilter; }

            ViewBag.CurrentFilter = searchString;

            //Filtering
            if (!String.IsNullOrEmpty(searchString))
            {
                faceOrientationsData = faceOrientationsData.Where
                    (s => s.Orientation.ToString().ToUpper().Contains(searchString.ToUpper())
                    //|| s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Orientation_desc":
                    faceOrientationsData = faceOrientationsData.OrderByDescending(s => s.Orientation);
                    break;

                default:
                    faceOrientationsData = faceOrientationsData.OrderBy(s => s.Orientation);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await faceOrientationsData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: FaceOrientations/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceOrientation faceOrientation = await db.FaceOrientations.FindAsync(id);
            if (faceOrientation == null)
            {
                return HttpNotFound();
            }
            return View(faceOrientation);
        }

        // GET: FaceOrientations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FaceOrientations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FaceOrientationID,Orientation")] FaceOrientation faceOrientation)
        {
            if (ModelState.IsValid)
            {
                db.FaceOrientations.Add(faceOrientation);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(faceOrientation);
        }

        // GET: FaceOrientations/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceOrientation faceOrientation = await db.FaceOrientations.FindAsync(id);
            if (faceOrientation == null)
            {
                return HttpNotFound();
            }
            return View(faceOrientation);
        }

        // POST: FaceOrientations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FaceOrientationID,Orientation")] FaceOrientation faceOrientation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faceOrientation).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(faceOrientation);
        }

        // GET: FaceOrientations/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceOrientation faceOrientation = await db.FaceOrientations.FindAsync(id);
            if (faceOrientation == null)
            {
                return HttpNotFound();
            }
            return View(faceOrientation);
        }

        // POST: FaceOrientations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FaceOrientation faceOrientation = await db.FaceOrientations.FindAsync(id);
            db.FaceOrientations.Remove(faceOrientation);
            await db.SaveChangesAsync();
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
