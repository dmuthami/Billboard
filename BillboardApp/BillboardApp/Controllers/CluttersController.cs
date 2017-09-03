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
    public class CluttersController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Clutters
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.ParameterSortParm = String.IsNullOrEmpty(sortOrder) ? "Parameter_desc" : "";
            ViewBag.ScoreSortParm = sortOrder == "Score" ? "Score_desc" : "Score";

            IQueryable<ClutterViewModel> cluttersData = from clutters in db.Clutters
                                                                select new ClutterViewModel()
                                                                        {
                                                                            ClutterID = clutters.ClutterID,
                                                                            Parameter = clutters.Parameter,
                                                                            Score = clutters.Score
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
                cluttersData = cluttersData.Where
                    (s => s.Parameter.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.Score.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Parameter_desc":
                    cluttersData = cluttersData.OrderByDescending(s => s.Parameter);
                    break;
                case "Score":
                    cluttersData = cluttersData.OrderBy(s => s.Score);
                    break;
                case "Score_desc":
                    cluttersData = cluttersData.OrderByDescending(s => s.Score);
                    break;
                default:
                    cluttersData = cluttersData.OrderBy(s => s.Parameter);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await cluttersData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: Clutters/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clutter clutter = await db.Clutters.FindAsync(id);
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
        public async Task<ActionResult> Create([Bind(Include = "ClutterID,Parameter,Score")] Clutter clutter)
        {
            if (ModelState.IsValid)
            {
                db.Clutters.Add(clutter);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(clutter);
        }

        // GET: Clutters/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clutter clutter = await db.Clutters.FindAsync(id);
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
        public async Task<ActionResult> Edit([Bind(Include = "ClutterID,Parameter,Score")] Clutter clutter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clutter).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(clutter);
        }

        // GET: Clutters/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clutter clutter = await db.Clutters.FindAsync(id);
            if (clutter == null)
            {
                return HttpNotFound();
            }
            return View(clutter);
        }

        // POST: Clutters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Clutter clutter = await db.Clutters.FindAsync(id);
            db.Clutters.Remove(clutter);
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
