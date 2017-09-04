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
    public class FaceCluttersController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Clutters
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.ParameterSortParm = String.IsNullOrEmpty(sortOrder) ? "Parameter_desc" : "";
            ViewBag.ScoreSortParm = sortOrder == "Score" ? "Score_desc" : "Score";

            IQueryable<FaceClutterViewModel> faceCluttersData = from faceClutters in db.FaceClutters
                                                                select new FaceClutterViewModel()
                                                                        {
                                                                            FaceClutterID = faceClutters.FaceClutterID,
                                                                            Parameter = faceClutters.Parameter,
                                                                            Score = faceClutters.Score
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
                faceCluttersData = faceCluttersData.Where
                    (s => s.Parameter.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.Score.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Parameter_desc":
                    faceCluttersData = faceCluttersData.OrderByDescending(s => s.Parameter);
                    break;
                case "Score":
                    faceCluttersData = faceCluttersData.OrderBy(s => s.Score);
                    break;
                case "Score_desc":
                    faceCluttersData = faceCluttersData.OrderByDescending(s => s.Score);
                    break;
                default:
                    faceCluttersData = faceCluttersData.OrderBy(s => s.Parameter);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await faceCluttersData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: Clutters/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceClutter clutter = await db.FaceClutters.FindAsync(id);
            if (clutter == null)
            {
                return HttpNotFound();
            }
            return View(clutter);
        }

        // GET: Clutters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clutters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FaceClutterID,Parameter,Score")] FaceClutter faceClutter)
        {
            if (ModelState.IsValid)
            {
                db.FaceClutters.Add(faceClutter);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(faceClutter);
        }

        // GET: Clutters/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceClutter clutter = await db.FaceClutters.FindAsync(id);
            if (clutter == null)
            {
                return HttpNotFound();
            }
            return View(clutter);
        }

        // POST: Clutters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FaceClutterID,Parameter,Score")] FaceClutter faceClutter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faceClutter).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(faceClutter);
        }

        // GET: Clutters/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceClutter faceClutter = await db.FaceClutters.FindAsync(id);
            if (faceClutter == null)
            {
                return HttpNotFound();
            }
            return View(faceClutter);
        }

        // POST: Clutters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FaceClutter faceClutter = await db.FaceClutters.FindAsync(id);
            db.FaceClutters.Remove(faceClutter);
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
