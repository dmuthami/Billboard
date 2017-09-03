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
    public class TrafficController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Traffic
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.ParameterSortParm = String.IsNullOrEmpty(sortOrder) ? "Parameter_desc" : "";
            ViewBag.ScoreSortParm = sortOrder == "Score" ? "Score_desc" : "Score";

            IQueryable<TrafficViewModel> trafficsData = from traffics in db.Traffics
                                                                select new TrafficViewModel()
                                                                        {
                                                                            TrafficID = traffics.TrafficID,
                                                                            Parameter = traffics.Parameter,
                                                                            Score = traffics.Score
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
                trafficsData = trafficsData.Where
                    (s => s.Parameter.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.Score.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Type_desc":
                    trafficsData = trafficsData.OrderByDescending(s => s.Parameter);
                    break;
                case "Score":
                    trafficsData = trafficsData.OrderBy(s => s.Score);
                    break;
                case "Score_desc":
                    trafficsData = trafficsData.OrderByDescending(s => s.Score);
                    break;
                default:
                    trafficsData = trafficsData.OrderBy(s => s.Parameter);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await trafficsData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: Traffic/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Traffic traffic = await db.Traffics.FindAsync(id);
            if (traffic == null)
            {
                return HttpNotFound();
            }
            return View(traffic);
        }

        // GET: Traffic/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Traffic/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TrafficID,Paramameter,Score")] Traffic traffic)
        {
            if (ModelState.IsValid)
            {
                db.Traffics.Add(traffic);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(traffic);
        }

        // GET: Traffic/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Traffic traffic = await db.Traffics.FindAsync(id);
            if (traffic == null)
            {
                return HttpNotFound();
            }
            return View(traffic);
        }

        // POST: Traffic/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TrafficID,Paramameter,Score")] Traffic traffic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(traffic).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(traffic);
        }

        // GET: Traffic/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Traffic traffic = await db.Traffics.FindAsync(id);
            if (traffic == null)
            {
                return HttpNotFound();
            }
            return View(traffic);
        }

        // POST: Traffic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Traffic traffic = await db.Traffics.FindAsync(id);
            db.Traffics.Remove(traffic);
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
