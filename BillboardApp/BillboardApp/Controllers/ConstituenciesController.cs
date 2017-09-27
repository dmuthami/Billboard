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
    public class ConstituenciesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Constituencies
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "";
            ViewBag.AbbreviationSortParm = sortOrder == "Abbreviation" ? "Abbreviation_desc" : "Abbreviation";

            IQueryable<ConstituencyViewModel> constituencysData = from constituencys in db.Constituencys
                                                              select new ConstituencyViewModel()
                                                              {
                                                                  ConstituencyID = constituencys.ConstituencyID,
                                                                  Name = constituencys.Name,
                                                                  Abbreviation = constituencys.Abbreviation
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
                constituencysData = constituencysData.Where
                    (s => s.Name.ToString().ToUpper().Contains(searchString.ToUpper())
                    //|| s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Name_desc":
                    constituencysData = constituencysData.OrderByDescending(s => s.Name);
                    break;
                case "Abbreviation":
                    constituencysData = constituencysData.OrderBy(s => s.Abbreviation);
                    break;
                case "Abbreviation_desc":
                    constituencysData = constituencysData.OrderByDescending(s => s.Abbreviation);
                    break;
                default:
                    constituencysData = constituencysData.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await constituencysData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: Constituencies/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constituency constituency = await db.Constituencys.FindAsync(id);
            if (constituency == null)
            {
                return HttpNotFound();
            }
            return View(constituency);
        }

        // GET: Constituencies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Constituencies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ConstituencyID,Name,Abbreviation,Geom")] Constituency constituency)
        {
            if (ModelState.IsValid)
            {
                db.Constituencys.Add(constituency);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(constituency);
        }

        // GET: Constituencies/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constituency constituency = await db.Constituencys.FindAsync(id);
            if (constituency == null)
            {
                return HttpNotFound();
            }
            return View(constituency);
        }

        // POST: Constituencies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ConstituencyID,Name,Abbreviation,Geom")] Constituency constituency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(constituency).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(constituency);
        }

        // GET: Constituencies/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Constituency constituency = await db.Constituencys.FindAsync(id);
            if (constituency == null)
            {
                return HttpNotFound();
            }
            return View(constituency);
        }

        // POST: Constituencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Constituency constituency = await db.Constituencys.FindAsync(id);
            db.Constituencys.Remove(constituency);
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
