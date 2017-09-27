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
    public class VegetationCoversController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: VegetationCovers
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //

            ViewBag.ParameterSortParm = String.IsNullOrEmpty(sortOrder) ? "Parameter_desc" : "";
            ViewBag.ScoreSortParm = sortOrder == "Score" ? "Score_desc" : "Score";

            IQueryable<VegetationCoverViewModel> vegetationCoversData = from vegetationCovers in db.VegetationCovers
                                                                        select new VegetationCoverViewModel()
                                                                        {
                                                                            VegetationCoverID = vegetationCovers.VegetationCoverID,
                                                                            Parameter = vegetationCovers.Parameter,
                                                                            Score = vegetationCovers.Score
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
                vegetationCoversData = vegetationCoversData.Where
                    (s => s.Parameter.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.Score.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Parameter_desc":
                    vegetationCoversData = vegetationCoversData.OrderByDescending(s => s.Parameter);
                    break;
                case "Score":
                    vegetationCoversData = vegetationCoversData.OrderBy(s => s.Score);
                    break;
                case "Score_desc":
                    vegetationCoversData = vegetationCoversData.OrderByDescending(s => s.Score);
                    break;
                default:
                    vegetationCoversData = vegetationCoversData.OrderBy(s => s.Parameter);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await vegetationCoversData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: VegetationCovers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VegetationCover vegetationCover = await db.VegetationCovers.FindAsync(id);
            if (vegetationCover == null)
            {
                return HttpNotFound();
            }
            return View(vegetationCover);
        }

        // GET: VegetationCovers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VegetationCovers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "VegetationCoverID,Parameter,Score")] VegetationCover vegetationCover)
        {
            if (ModelState.IsValid)
            {
                db.VegetationCovers.Add(vegetationCover);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(vegetationCover);
        }

        // GET: VegetationCovers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VegetationCover vegetationCover = await db.VegetationCovers.FindAsync(id);
            if (vegetationCover == null)
            {
                return HttpNotFound();
            }
            return View(vegetationCover);
        }

        // POST: VegetationCovers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "VegetationCoverID,Parameter,Score")] VegetationCover vegetationCover)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vegetationCover).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vegetationCover);
        }

        // GET: VegetationCovers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VegetationCover vegetationCover = await db.VegetationCovers.FindAsync(id);
            if (vegetationCover == null)
            {
                return HttpNotFound();
            }
            return View(vegetationCover);
        }

        // POST: VegetationCovers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            VegetationCover vegetationCover = await db.VegetationCovers.FindAsync(id);
            db.VegetationCovers.Remove(vegetationCover);
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
