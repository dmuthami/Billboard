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
    public class FaceAvailabilitiesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: FaceAvailabilities
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.AvailabilityTypeSortParm = String.IsNullOrEmpty(sortOrder) ? "AvailabilityType_desc" : "";

            IQueryable<FaceAvailabilityViewModel> faceAvailabilitysData = from faceAvailabilitys in db.FaceAvailabilitys
                                                                    select new FaceAvailabilityViewModel()
                                                              {
                                                                  FaceAvailabilityID = faceAvailabilitys.FaceAvailabilityID,
                                                                  AvailabilityType = faceAvailabilitys.AvailabilityType
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
                faceAvailabilitysData = faceAvailabilitysData.Where
                    (s => s.AvailabilityType.ToString().ToUpper().Contains(searchString.ToUpper())
                    //|| s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "AvailabilityType_desc":
                    faceAvailabilitysData = faceAvailabilitysData.OrderByDescending(s => s.AvailabilityType);
                    break;
                default:
                    faceAvailabilitysData = faceAvailabilitysData.OrderBy(s => s.AvailabilityType);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await faceAvailabilitysData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: FaceAvailabilities/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceAvailability faceAvailability = await db.FaceAvailabilitys.FindAsync(id);
            if (faceAvailability == null)
            {
                return HttpNotFound();
            }
            return View(faceAvailability);
        }

        // GET: FaceAvailabilities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FaceAvailabilities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FaceAvailabilityID,AvailabilityType")] FaceAvailability faceAvailability)
        {
            if (ModelState.IsValid)
            {
                db.FaceAvailabilitys.Add(faceAvailability);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(faceAvailability);
        }

        // GET: FaceAvailabilities/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceAvailability faceAvailability = await db.FaceAvailabilitys.FindAsync(id);
            if (faceAvailability == null)
            {
                return HttpNotFound();
            }
            return View(faceAvailability);
        }

        // POST: FaceAvailabilities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FaceAvailabilityID,AvailabilityType")] FaceAvailability faceAvailability)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faceAvailability).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(faceAvailability);
        }

        // GET: FaceAvailabilities/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceAvailability faceAvailability = await db.FaceAvailabilitys.FindAsync(id);
            if (faceAvailability == null)
            {
                return HttpNotFound();
            }
            return View(faceAvailability);
        }

        // POST: FaceAvailabilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FaceAvailability faceAvailability = await db.FaceAvailabilitys.FindAsync(id);
            db.FaceAvailabilitys.Remove(faceAvailability);
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
