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

            ViewBag.OccupancySortParm = String.IsNullOrEmpty(sortOrder) ? "Occupancy_desc" : "";


            IQueryable<FaceOccupancyViewModel> faceOccupancysData = from faceOccupancys in db.FaceOccupancys
                                                                 select new FaceOccupancyViewModel()
                                                              {
                                                                  FaceOccupancyID = faceOccupancys.FaceOccupancyID,
                                                                  Occupancy = faceOccupancys.Occupancy
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
                faceOccupancysData = faceOccupancysData.Where
                    (s => s.Occupancy.ToString().ToUpper().Contains(searchString.ToUpper())
                    //|| s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Occupancy_desc":
                    faceOccupancysData = faceOccupancysData.OrderByDescending(s => s.Occupancy);
                    break;
                default:
                    faceOccupancysData = faceOccupancysData.OrderBy(s => s.Occupancy);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await faceOccupancysData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: FaceOccupancies/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceOccupancy faceOccupancy = await db.FaceOccupancys.FindAsync(id);
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
        public async Task<ActionResult> Create([Bind(Include = "FaceOccupancyID,Occupancy")] FaceOccupancy faceOccupancy)
        {
            if (ModelState.IsValid)
            {
                db.FaceOccupancys.Add(faceOccupancy);
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
            FaceOccupancy faceOccupancy = await db.FaceOccupancys.FindAsync(id);
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
        public async Task<ActionResult> Edit([Bind(Include = "FaceOccupancyID,Occupancy")] FaceOccupancy faceOccupancy)
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
            FaceOccupancy faceOccupancy = await db.FaceOccupancys.FindAsync(id);
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
            FaceOccupancy faceOccupancy = await db.FaceOccupancys.FindAsync(id);
            db.FaceOccupancys.Remove(faceOccupancy);
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
