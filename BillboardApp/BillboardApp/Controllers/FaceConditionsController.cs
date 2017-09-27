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
    public class FaceConditionsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: FaceConditions
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.ConditionSortParm = String.IsNullOrEmpty(sortOrder) ? "Condition_desc" : "";

            IQueryable<FaceConditionViewModel> faceConditionsData = from faceConditions in db.FaceConditions
                                                                 select new FaceConditionViewModel()
                                                              {
                                                                  FaceConditionID = faceConditions.FaceConditionID,
                                                                  Condition = faceConditions.Condition
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
                faceConditionsData = faceConditionsData.Where
                    (s => s.Condition.ToString().ToUpper().Contains(searchString.ToUpper())
                    //|| s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Condition_desc":
                    faceConditionsData = faceConditionsData.OrderByDescending(s => s.Condition);
                    break;
                default:
                    faceConditionsData = faceConditionsData.OrderBy(s => s.Condition);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await faceConditionsData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: FaceConditions/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceCondition faceCondition = await db.FaceConditions.FindAsync(id);
            if (faceCondition == null)
            {
                return HttpNotFound();
            }
            return View(faceCondition);
        }

        // GET: FaceConditions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FaceConditions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FaceConditionID,Condition")] FaceCondition faceCondition)
        {
            if (ModelState.IsValid)
            {
                db.FaceConditions.Add(faceCondition);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(faceCondition);
        }

        // GET: FaceConditions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceCondition faceCondition = await db.FaceConditions.FindAsync(id);
            if (faceCondition == null)
            {
                return HttpNotFound();
            }
            return View(faceCondition);
        }

        // POST: FaceConditions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FaceConditionID,Condition")] FaceCondition faceCondition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faceCondition).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(faceCondition);
        }

        // GET: FaceConditions/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceCondition faceCondition = await db.FaceConditions.FindAsync(id);
            if (faceCondition == null)
            {
                return HttpNotFound();
            }
            return View(faceCondition);
        }

        // POST: FaceConditions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FaceCondition faceCondition = await db.FaceConditions.FindAsync(id);
            db.FaceConditions.Remove(faceCondition);
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
