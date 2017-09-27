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
    public class CountiesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Counties
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "";
            ViewBag.CodeSortParm = sortOrder == "Code" ? "Code_desc" : "Code";
            ViewBag.AbbreviationSortParm = sortOrder == "Abbreviation" ? "Abbreviation_desc" : "Abbreviation";

            IQueryable<CountyViewModel> countysData = from countys in db.Countys
                                                      select new CountyViewModel()
                                                              {
                                                                  Code = countys.Code,
                                                                  Name = countys.Name,
                                                                  Abbreviation = countys.Abbreviation
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
                countysData = countysData.Where
                    (s => s.Name.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.Code.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Name_desc":
                    countysData = countysData.OrderByDescending(s => s.Name);
                    break;
                case "Code":
                    countysData = countysData.OrderBy(s => s.Code);
                    break;
                case "Code_desc":
                    countysData = countysData.OrderByDescending(s => s.Code);
                    break;
                case "Abbreviation":
                    countysData = countysData.OrderBy(s => s.Abbreviation);
                    break;
                case "Abbreviation_desc":
                    countysData = countysData.OrderByDescending(s => s.Abbreviation);
                    break;
                default:
                    countysData = countysData.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await countysData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: Counties/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            County county = await db.Countys.FindAsync(id);
            if (county == null)
            {
                return HttpNotFound();
            }
            return View(county);
        }

        // GET: Counties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Counties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Code,DateCreated,DateRetired,Name,Abbreviation,Geom")] County county)
        {
            if (ModelState.IsValid)
            {
                db.Countys.Add(county);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(county);
        }

        // GET: Counties/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            County county = await db.Countys.FindAsync(id);
            if (county == null)
            {
                return HttpNotFound();
            }
            return View(county);
        }

        // POST: Counties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Code,DateCreated,DateRetired,Name,Abbreviation,Geom")] County county)
        {
            if (ModelState.IsValid)
            {
                db.Entry(county).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(county);
        }

        // GET: Counties/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            County county = await db.Countys.FindAsync(id);
            if (county == null)
            {
                return HttpNotFound();
            }
            return View(county);
        }

        // POST: Counties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            County county = await db.Countys.FindAsync(id);
            db.Countys.Remove(county);
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
