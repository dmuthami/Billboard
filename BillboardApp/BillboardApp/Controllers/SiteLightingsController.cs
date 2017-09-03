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
    public class SiteLightingsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: SiteLightings
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.ParameterSortParm = String.IsNullOrEmpty(sortOrder) ? "Parameter_desc" : "";
            ViewBag.ScoreSortParm = sortOrder == "Score" ? "Score_desc" : "Score";

            IQueryable<SiteLightingViewModel> siteLightingsData = from siteLightings in db.SiteLightings
                                                                     select new SiteLightingViewModel()
                                                                        {
                                                                            SiteLightingID = siteLightings.SiteLightingID,
                                                                            Parameter = siteLightings.Parameter,
                                                                            Score = siteLightings.Score
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
                siteLightingsData = siteLightingsData.Where
                    (s => s.Parameter.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.Score.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Parameter_desc":
                    siteLightingsData = siteLightingsData.OrderByDescending(s => s.Parameter);
                    break;
                case "Score":
                    siteLightingsData = siteLightingsData.OrderBy(s => s.Score);
                    break;
                case "Score_desc":
                    siteLightingsData = siteLightingsData.OrderByDescending(s => s.Score);
                    break;
                default:
                    siteLightingsData = siteLightingsData.OrderBy(s => s.Parameter);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await siteLightingsData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: SiteLightings/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SiteLighting siteLighting = await db.SiteLightings.FindAsync(id);
            if (siteLighting == null)
            {
                return HttpNotFound();
            }
            return View(siteLighting);
        }

        // GET: SiteLightings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SiteLightings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SiteLightingID,Parameter,Score")] SiteLighting siteLighting)
        {
            if (ModelState.IsValid)
            {
                db.SiteLightings.Add(siteLighting);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(siteLighting);
        }

        // GET: SiteLightings/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SiteLighting siteLighting = await db.SiteLightings.FindAsync(id);
            if (siteLighting == null)
            {
                return HttpNotFound();
            }
            return View(siteLighting);
        }

        // POST: SiteLightings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SiteLightingID,Parameter,Score")] SiteLighting siteLighting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(siteLighting).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(siteLighting);
        }

        // GET: SiteLightings/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SiteLighting siteLighting = await db.SiteLightings.FindAsync(id);
            if (siteLighting == null)
            {
                return HttpNotFound();
            }
            return View(siteLighting);
        }

        // POST: SiteLightings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SiteLighting siteLighting = await db.SiteLightings.FindAsync(id);
            db.SiteLightings.Remove(siteLighting);
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
