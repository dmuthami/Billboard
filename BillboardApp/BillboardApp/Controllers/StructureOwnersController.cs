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
    public class StructureOwnersController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: StructureOwners
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "";
            ViewBag.EmailSortParm = sortOrder == "Email" ? "Email_desc" : "Email";
            ViewBag.MobileNumberSortParm = sortOrder == "MobileNumber" ? "MobileNumber_desc" : "MobileNumber";            

            IQueryable<StructureOwnerViewModel> structureOwnersData = from structureOwners in db.StructureOwners
                                                                      select new StructureOwnerViewModel()
                                                              {
                                                                  StructureOwnerID = structureOwners.StructureOwnerID,
                                                                  Name = structureOwners.Name,
                                                                  Email = structureOwners.Email,
                                                                  MobileNumber = structureOwners.MobileNumber
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
                structureOwnersData = structureOwnersData.Where
                    (s => s.Name.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.MobileNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Name_desc":
                    structureOwnersData = structureOwnersData.OrderByDescending(s => s.Name);
                    break;
                case "Email":
                    structureOwnersData = structureOwnersData.OrderBy(s => s.Email);
                    break;
                case "Email_desc":
                    structureOwnersData = structureOwnersData.OrderByDescending(s => s.Email);
                    break;
                case "MobileNumber":
                    structureOwnersData = structureOwnersData.OrderBy(s => s.MobileNumber);
                    break;
                case "MobileNumber_desc":
                    structureOwnersData = structureOwnersData.OrderByDescending(s => s.MobileNumber);
                    break;
                default:
                    structureOwnersData = structureOwnersData.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await structureOwnersData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: StructureOwners/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StructureOwner structureOwner = await db.StructureOwners.FindAsync(id);
            if (structureOwner == null)
            {
                return HttpNotFound();
            }
            return View(structureOwner);
        }

        // GET: StructureOwners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StructureOwners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "StructureOwnerID,Name,Email,MobileNumber")] StructureOwner structureOwner)
        {
            if (ModelState.IsValid)
            {
                db.StructureOwners.Add(structureOwner);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(structureOwner);
        }

        // GET: StructureOwners/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StructureOwner structureOwner = await db.StructureOwners.FindAsync(id);
            if (structureOwner == null)
            {
                return HttpNotFound();
            }
            return View(structureOwner);
        }

        // POST: StructureOwners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "StructureOwnerID,Name,Email,MobileNumber")] StructureOwner structureOwner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(structureOwner).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(structureOwner);
        }

        // GET: StructureOwners/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StructureOwner structureOwner = await db.StructureOwners.FindAsync(id);
            if (structureOwner == null)
            {
                return HttpNotFound();
            }
            return View(structureOwner);
        }

        // POST: StructureOwners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            StructureOwner structureOwner = await db.StructureOwners.FindAsync(id);
            db.StructureOwners.Remove(structureOwner);
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
