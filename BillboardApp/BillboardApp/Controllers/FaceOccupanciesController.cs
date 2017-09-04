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
    public class FaceOccupanciesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: FaceOccupancies
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.OccupancyTypeSortParm = String.IsNullOrEmpty(sortOrder) ? "OccupancyType_desc" : "";

            IQueryable<FaceOccupancyViewModel> FaceOccupanciesData = from FaceOccupancies in db.FaceOccupancies
                                                                       select new FaceOccupancyViewModel()
                                                              {
                                                                  FaceOccupancyID = FaceOccupancies.FaceOccupancyID,
                                                                  OccupancyType = FaceOccupancies.OccupancyType
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
                FaceOccupanciesData = FaceOccupanciesData.Where
                    (s => s.OccupancyType.ToString().ToUpper().Contains(searchString.ToUpper())
                    //|| s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "OccupancyType_desc":
                    FaceOccupanciesData = FaceOccupanciesData.OrderByDescending(s => s.OccupancyType);
                    break;
                default:
                    FaceOccupanciesData = FaceOccupanciesData.OrderBy(s => s.OccupancyType);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await FaceOccupanciesData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: FaceOccupancies/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceOccupancy faceOccupancy = await db.FaceOccupancies.FindAsync(id);
            if (faceOccupancy == null)
            {
                return HttpNotFound();
            }
            return View(faceOccupancy);
        }

        // GET: FaceOccupancies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FaceOccupancies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FaceOccupancyID,OccupancyType")] FaceOccupancy faceOccupancy)
        {
            if (ModelState.IsValid)
            {
                db.FaceOccupancies.Add(faceOccupancy);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(faceOccupancy);
        }

        // GET: FaceOccupancies/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceOccupancy faceOccupancy = await db.FaceOccupancies.FindAsync(id);
            if (faceOccupancy == null)
            {
                return HttpNotFound();
            }
            return View(faceOccupancy);
        }

        // POST: FaceOccupancies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FaceOccupancyID,OccupancyType")] FaceOccupancy faceOccupancy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faceOccupancy).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(faceOccupancy);
        }

        // GET: FaceOccupancies/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceOccupancy faceOccupancy = await db.FaceOccupancies.FindAsync(id);
            if (faceOccupancy == null)
            {
                return HttpNotFound();
            }
            return View(faceOccupancy);
        }

        // POST: FaceOccupancies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FaceOccupancy faceOccupancy = await db.FaceOccupancies.FindAsync(id);
            db.FaceOccupancies.Remove(faceOccupancy);
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
