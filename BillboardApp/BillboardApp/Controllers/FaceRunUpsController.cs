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
    public class FaceRunUpsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: SiteRunUps
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.ParameterSortParm = String.IsNullOrEmpty(sortOrder) ? "Parameter_desc" : "";
            ViewBag.ScoreSortParm = sortOrder == "Score" ? "Score_desc" : "Score";

            IQueryable<FaceRunUpViewModel> siteRunUpsData = from siteRunUps in db.SiteRunUps
                                                                  select new FaceRunUpViewModel()
                                                                        {
                                                                            FaceRunUpID = siteRunUps.FaceRunUpID,
                                                                            Parameter = siteRunUps.Parameter,
                                                                            Score = siteRunUps.Score
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
                siteRunUpsData = siteRunUpsData.Where
                    (s => s.Parameter.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.Score.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Parameter_desc":
                    siteRunUpsData = siteRunUpsData.OrderByDescending(s => s.Parameter);
                    break;
                case "Score":
                    siteRunUpsData = siteRunUpsData.OrderBy(s => s.Score);
                    break;
                case "Score_desc":
                    siteRunUpsData = siteRunUpsData.OrderByDescending(s => s.Score);
                    break;
                default:
                    siteRunUpsData = siteRunUpsData.OrderBy(s => s.Parameter);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await siteRunUpsData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: SiteRunUps/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceRunUp siteRunUp = await db.SiteRunUps.FindAsync(id);
            if (siteRunUp == null)
            {
                return HttpNotFound();
            }
            return View(siteRunUp);
        }

        // GET: SiteRunUps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SiteRunUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FaceRunUpID,Parameter,Score")] FaceRunUp siteRunUp)
        {
            if (ModelState.IsValid)
            {
                db.SiteRunUps.Add(siteRunUp);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(siteRunUp);
        }

        // GET: SiteRunUps/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceRunUp siteRunUp = await db.SiteRunUps.FindAsync(id);
            if (siteRunUp == null)
            {
                return HttpNotFound();
            }
            return View(siteRunUp);
        }

        // POST: SiteRunUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FaceRunUpID,Parameter,Score")] FaceRunUp siteRunUp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(siteRunUp).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(siteRunUp);
        }

        // GET: SiteRunUps/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceRunUp siteRunUp = await db.SiteRunUps.FindAsync(id);
            if (siteRunUp == null)
            {
                return HttpNotFound();
            }
            return View(siteRunUp);
        }

        // POST: SiteRunUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FaceRunUp siteRunUp = await db.SiteRunUps.FindAsync(id);
            db.SiteRunUps.Remove(siteRunUp);
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
