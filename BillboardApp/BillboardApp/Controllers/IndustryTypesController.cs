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
    public class IndustryTypesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: IndustryTypes
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            
            ViewBag.TypeSortParm = String.IsNullOrEmpty(sortOrder) ? "Type_desc" : "";

            IQueryable<IndustryTypeViewModel> industryTypesData = from industryTypes in db.IndustryTypes
                                                                select new IndustryTypeViewModel()
                                                              {
                                                                  IndustryTypeID = industryTypes.IndustryTypeID,
                                                                  Type = industryTypes.Type
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
                industryTypesData = industryTypesData.Where
                    (s => s.Type.ToString().ToUpper().Contains(searchString.ToUpper())
                    //|| s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Type_desc":
                    industryTypesData = industryTypesData.OrderByDescending(s => s.Type);
                    break;

                default:
                    industryTypesData = industryTypesData.OrderBy(s => s.Type);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await industryTypesData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: IndustryTypes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndustryType industryType = await db.IndustryTypes.FindAsync(id);
            if (industryType == null)
            {
                return HttpNotFound();
            }
            return View(industryType);
        }

        // GET: IndustryTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IndustryTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IndustryTypeID,Type")] IndustryType industryType)
        {
            if (ModelState.IsValid)
            {
                db.IndustryTypes.Add(industryType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(industryType);
        }

        // GET: IndustryTypes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndustryType industryType = await db.IndustryTypes.FindAsync(id);
            if (industryType == null)
            {
                return HttpNotFound();
            }
            return View(industryType);
        }

        // POST: IndustryTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IndustryTypeID,Type")] IndustryType industryType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(industryType).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(industryType);
        }

        // GET: IndustryTypes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IndustryType industryType = await db.IndustryTypes.FindAsync(id);
            if (industryType == null)
            {
                return HttpNotFound();
            }
            return View(industryType);
        }

        // POST: IndustryTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            IndustryType industryType = await db.IndustryTypes.FindAsync(id);
            db.IndustryTypes.Remove(industryType);
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
