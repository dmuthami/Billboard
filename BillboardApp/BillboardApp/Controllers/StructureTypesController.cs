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
    public class StructureTypesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: StructureTypes
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //return View(await db.StructureTypes.ToListAsync());

            ViewBag.TypeSortParm = String.IsNullOrEmpty(sortOrder) ? "Type_desc" : "";

            IQueryable<StructureTypeViewModel> structureTypesData = from structureTypes in db.StructureTypes
                                                                 select new StructureTypeViewModel()
                                                              {
                                                                  StructureTypeID = structureTypes.StructureTypeID,
                                                                  Type = structureTypes.Type
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
                structureTypesData = structureTypesData.Where
                    (s => s.Type.ToString().ToUpper().Contains(searchString.ToUpper())
                    //|| s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Name_desc":
                    structureTypesData = structureTypesData.OrderByDescending(s => s.Type);
                    break;
                default:
                    structureTypesData = structureTypesData.OrderBy(s => s.Type);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await structureTypesData.ToPagedListAsync(pageNumber, pageSize));


        }

        // GET: StructureTypes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StructureType structureType = await db.StructureTypes.FindAsync(id);
            if (structureType == null)
            {
                return HttpNotFound();
            }
            return View(structureType);
        }

        // GET: StructureTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StructureTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "StructureTypeID,Type")] StructureType structureType)
        {
            if (ModelState.IsValid)
            {
                db.StructureTypes.Add(structureType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(structureType);
        }

        // GET: StructureTypes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StructureType structureType = await db.StructureTypes.FindAsync(id);
            if (structureType == null)
            {
                return HttpNotFound();
            }
            return View(structureType);
        }

        // POST: StructureTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "StructureTypeID,Type")] StructureType structureType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(structureType).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(structureType);
        }

        // GET: StructureTypes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StructureType structureType = await db.StructureTypes.FindAsync(id);
            if (structureType == null)
            {
                return HttpNotFound();
            }
            return View(structureType);
        }

        // POST: StructureTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            StructureType structureType = await db.StructureTypes.FindAsync(id);
            db.StructureTypes.Remove(structureType);
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
