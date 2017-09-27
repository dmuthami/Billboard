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
    public class WardsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Wards
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "";
            ViewBag.AbbreviationSortParm = sortOrder == "Abbreviation" ? "Abbreviation_desc" : "Abbreviation";

            IQueryable<WardViewModel> wardsData = from wards in db.Wards
                                                  select new WardViewModel()
                                                              {
                                                                  WardID = wards.WardID,
                                                                  Name = wards.Name,
                                                                  Abbreviation = wards.Abbreviation
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
                wardsData = wardsData.Where
                    (s => s.Name.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.Abbreviation.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Name_desc":
                    wardsData = wardsData.OrderByDescending(s => s.Name);
                    break;
                case "Abbreviation":
                    wardsData = wardsData.OrderBy(s => s.Abbreviation);
                    break;
                case "Abbreviation_desc":
                    wardsData = wardsData.OrderByDescending(s => s.Abbreviation);
                    break;
                default:
                    wardsData = wardsData.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await wardsData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: Wards/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ward ward = await db.Wards.FindAsync(id);
            if (ward == null)
            {
                return HttpNotFound();
            }
            return View(ward);
        }

        // GET: Wards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "WardID,Name,Abbreviation,Geom")] Ward ward)
        {
            if (ModelState.IsValid)
            {
                db.Wards.Add(ward);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ward);
        }

        // GET: Wards/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ward ward = await db.Wards.FindAsync(id);
            if (ward == null)
            {
                return HttpNotFound();
            }
            return View(ward);
        }

        // POST: Wards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "WardID,Name,Abbreviation,Geom")] Ward ward)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ward).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ward);
        }

        // GET: Wards/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ward ward = await db.Wards.FindAsync(id);
            if (ward == null)
            {
                return HttpNotFound();
            }
            return View(ward);
        }

        // POST: Wards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Ward ward = await db.Wards.FindAsync(id);
            db.Wards.Remove(ward);
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
