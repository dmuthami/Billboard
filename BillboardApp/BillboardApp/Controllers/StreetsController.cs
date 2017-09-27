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
    public class StreetsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Streets
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.StreetNameByCollectorSortParm = String.IsNullOrEmpty(sortOrder) ? "StreetNameByCollector_desc" : "";
            ViewBag.StreetNameByGISSortParm = sortOrder == "StreetNameByGIS" ? "StreetNameByGIS_desc" : "StreetNameByGIS";
            ViewBag.RouteSortParm = sortOrder == "Route" ? "Route_desc" : "Route";

            IQueryable<StreetViewModel> streetsData = from streets in db.Streets.Include(s => s.Route)
                                                      select new StreetViewModel()
                                                              {
                                                                  StreetID = streets.StreetID,
                                                                  StreetNameByCollector = streets.StreetNameByCollector,
                                                                  StreetNameByGIS = streets.StreetNameByGIS,
                                                                  Route = streets.Route.Name
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
                streetsData = streetsData.Where
                    (s => s.StreetNameByCollector.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.StreetNameByGIS.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "StreetNameByCollector_desc":
                    streetsData = streetsData.OrderByDescending(s => s.StreetNameByCollector);
                    break;
                case "StreetNameByGIS":
                    streetsData = streetsData.OrderBy(s => s.StreetNameByGIS);
                    break;
                case "StreetNameByGIS_desc":
                    streetsData = streetsData.OrderByDescending(s => s.StreetNameByGIS);
                    break;
                case "Route":
                    streetsData = streetsData.OrderBy(s => s.Route);
                    break;
                case "Route_desc":
                    streetsData = streetsData.OrderByDescending(s => s.Route);
                    break;
                default:
                    streetsData = streetsData.OrderBy(s => s.StreetNameByCollector);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await streetsData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: Streets/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Street street = await db.Streets.FindAsync(id);
            if (street == null)
            {
                return HttpNotFound();
            }
            return View(street);
        }

        // GET: Streets/Create
        public ActionResult Create()
        {
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "Name");
            return View();
        }

        // POST: Streets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "StreetID,StreetNameByCollector,StreetNameByGIS,RouteID")] Street street)
        {
            if (ModelState.IsValid)
            {
                db.Streets.Add(street);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "Name", street.RouteID);
            return View(street);
        }

        // GET: Streets/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Street street = await db.Streets.FindAsync(id);
            if (street == null)
            {
                return HttpNotFound();
            }
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "Name", street.RouteID);
            return View(street);
        }

        // POST: Streets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "StreetID,StreetNameByCollector,StreetNameByGIS,RouteID")] Street street)
        {
            if (ModelState.IsValid)
            {
                db.Entry(street).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "Name", street.RouteID);
            return View(street);
        }

        // GET: Streets/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Street street = await db.Streets.FindAsync(id);
            if (street == null)
            {
                return HttpNotFound();
            }
            return View(street);
        }

        // POST: Streets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Street street = await db.Streets.FindAsync(id);
            db.Streets.Remove(street);
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
