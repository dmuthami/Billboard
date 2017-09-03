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
    public class FacePositionsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: FacePositions
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.PositionSortParm = String.IsNullOrEmpty(sortOrder) ? "Position_desc" : "";


            IQueryable<FacePositionViewModel> facePositionData = from facePosition in db.FacePosition
                                                                 select new FacePositionViewModel()
                                                              {
                                                                  FacePositionID = facePosition.FacePositionID,
                                                                  Position = facePosition.Position
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
                facePositionData = facePositionData.Where
                    (s => s.Position.ToString().ToUpper().Contains(searchString.ToUpper())
                    //|| s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Position_desc":
                    facePositionData = facePositionData.OrderByDescending(s => s.Position);
                    break;
                default:
                    facePositionData = facePositionData.OrderBy(s => s.Position);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await facePositionData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: FacePositions/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacePosition facePosition = await db.FacePosition.FindAsync(id);
            if (facePosition == null)
            {
                return HttpNotFound();
            }
            return View(facePosition);
        }

        // GET: FacePositions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FacePositions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FacePositionID,Position")] FacePosition facePosition)
        {
            if (ModelState.IsValid)
            {
                db.FacePosition.Add(facePosition);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(facePosition);
        }

        // GET: FacePositions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacePosition facePosition = await db.FacePosition.FindAsync(id);
            if (facePosition == null)
            {
                return HttpNotFound();
            }
            return View(facePosition);
        }

        // POST: FacePositions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FacePositionID,Position")] FacePosition facePosition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facePosition).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(facePosition);
        }

        // GET: FacePositions/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FacePosition facePosition = await db.FacePosition.FindAsync(id);
            if (facePosition == null)
            {
                return HttpNotFound();
            }
            return View(facePosition);
        }

        // POST: FacePositions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FacePosition facePosition = await db.FacePosition.FindAsync(id);
            db.FacePosition.Remove(facePosition);
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
