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
    public class FaceTrafficController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: FaceTraffic
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.ParameterSortParm = String.IsNullOrEmpty(sortOrder) ? "Parameter_desc" : "";
            ViewBag.ScoreSortParm = sortOrder == "Score" ? "Score_desc" : "Score";

            IQueryable<FaceTrafficViewModel> faceTrafficData = from traffics in db.FaceTraffics
                                                                select new FaceTrafficViewModel()
                                                                        {
                                                                            FaceTrafficID = traffics.FaceTrafficID,
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
                faceTrafficData = faceTrafficData.Where
                    (s => s.Parameter.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.Score.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Type_desc":
                    faceTrafficData = faceTrafficData.OrderByDescending(s => s.Parameter);
                    break;
                case "Score":
                    faceTrafficData = faceTrafficData.OrderBy(s => s.Score);
                    break;
                case "Score_desc":
                    faceTrafficData = faceTrafficData.OrderByDescending(s => s.Score);
                    break;
                default:
                    faceTrafficData = faceTrafficData.OrderBy(s => s.Parameter);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await faceTrafficData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: FaceTraffic/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceTraffic faceTraffic = await db.FaceTraffics.FindAsync(id);
            if (faceTraffic == null)
            {
                return HttpNotFound();
            }
            return View(faceTraffic);
        }

        // GET: FaceTraffic/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FaceTraffic/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FaceTrafficID,Parameter,Score")] FaceTraffic faceTraffic)
        {
            if (ModelState.IsValid)
            {
                db.FaceTraffics.Add(faceTraffic);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(faceTraffic);
        }

        // GET: FaceTraffic/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceTraffic faceTraffic = await db.FaceTraffics.FindAsync(id);
            if (faceTraffic == null)
            {
                return HttpNotFound();
            }
            return View(faceTraffic);
        }

        // POST: FaceTraffic/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FaceTrafficID,Parameter,Score")] FaceTraffic faceTraffic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faceTraffic).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(faceTraffic);
        }

        // GET: FaceTraffic/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceTraffic faceTraffic = await db.FaceTraffics.FindAsync(id);
            if (faceTraffic == null)
            {
                return HttpNotFound();
            }
            return View(faceTraffic);
        }

        // POST: FaceTraffic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FaceTraffic faceTraffic = await db.FaceTraffics.FindAsync(id);
            db.FaceTraffics.Remove(faceTraffic);
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

        /// <summary>
        /// Error handler
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnException(ExceptionContext filterContext)
        {
            Exception exception = filterContext.Exception;
            //Logging the Exception
            filterContext.ExceptionHandled = true;


            var Result = this.View("Error", new HandleErrorInfo(exception,
                filterContext.RouteData.Values["controller"].ToString(),
                filterContext.RouteData.Values["action"].ToString()));

            filterContext.Result = Result;

        }
    }
}
