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
    public class FaceBoundsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: FaceBounds
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.BoundSortParm = String.IsNullOrEmpty(sortOrder) ? "Bound_desc" : "";

            IQueryable<FaceBoundViewModel> faceBoundsData = from faceBounds in db.FaceBounds
                                                             select new FaceBoundViewModel()
                                                              {
                                                                  FaceBoundID = faceBounds.FaceBoundID,
                                                                  Bound = faceBounds.Bound
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
                faceBoundsData = faceBoundsData.Where
                    (s => s.Bound.ToString().ToUpper().Contains(searchString.ToUpper())
                    //|| s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Bound_desc":
                    faceBoundsData = faceBoundsData.OrderByDescending(s => s.Bound);
                    break;
                default:
                    faceBoundsData = faceBoundsData.OrderBy(s => s.Bound);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await faceBoundsData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: FaceBounds/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceBound faceBound = await db.FaceBounds.FindAsync(id);
            if (faceBound == null)
            {
                return HttpNotFound();
            }
            return View(faceBound);
        }

        // GET: FaceBounds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FaceBounds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FaceBoundID,Bound")] FaceBound faceBound)
        {
            if (ModelState.IsValid)
            {
                db.FaceBounds.Add(faceBound);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(faceBound);
        }

        // GET: FaceBounds/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceBound faceBound = await db.FaceBounds.FindAsync(id);
            if (faceBound == null)
            {
                return HttpNotFound();
            }
            return View(faceBound);
        }

        // POST: FaceBounds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FaceBoundID,Bound")] FaceBound faceBound)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faceBound).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(faceBound);
        }

        // GET: FaceBounds/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceBound faceBound = await db.FaceBounds.FindAsync(id);
            if (faceBound == null)
            {
                return HttpNotFound();
            }
            return View(faceBound);
        }

        // POST: FaceBounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FaceBound faceBound = await db.FaceBounds.FindAsync(id);
            db.FaceBounds.Remove(faceBound);
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
