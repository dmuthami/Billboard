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
    public class IndustriesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Industries
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "";
            ViewBag.TypeSortParm = sortOrder == "Type" ? "Type_desc" : "Type";

            IQueryable<IndustryViewModel> industriesData = from industries in db.Industrys.Include(i => i.IndustryType)
                                                           select new IndustryViewModel()
                                                           {
                                                               IndustryID = industries.IndustryID,
                                                               Name = industries.Name,
                                                               Type = industries.IndustryType.Type

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
                industriesData = industriesData.Where
                    (s => s.Name.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.Type.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Name_desc":
                    industriesData = industriesData.OrderByDescending(s => s.Name);
                    break;
                case "Type":
                    industriesData = industriesData.OrderBy(s => s.Type);
                    break;
                case "Type_desc":
                    industriesData = industriesData.OrderByDescending(s => s.Type);
                    break;
                default:
                    industriesData = industriesData.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await industriesData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: Industries/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Industry industry = await db.Industrys.FindAsync(id);
            if (industry == null)
            {
                return HttpNotFound();
            }
            return View(industry);
        }

        // GET: Industries/Create
        public ActionResult Create()
        {
            ViewBag.IndustryTypeID = new SelectList(db.IndustryTypes, "IndustryTypeID", "Type");
            return View();
        }

        // POST: Industries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "IndustryID,Name,IndustryTypeID")] Industry industry)
        {
            if (ModelState.IsValid)
            {
                db.Industrys.Add(industry);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.IndustryTypeID = new SelectList(db.IndustryTypes, "IndustryTypeID", "Type", industry.IndustryTypeID);
            return View(industry);
        }

        // GET: Industries/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Industry industry = await db.Industrys.FindAsync(id);
            if (industry == null)
            {
                return HttpNotFound();
            }
            ViewBag.IndustryTypeID = new SelectList(db.IndustryTypes, "IndustryTypeID", "Type", industry.IndustryTypeID);
            return View(industry);
        }

        // POST: Industries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "IndustryID,Name,IndustryTypeID")] Industry industry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(industry).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.IndustryTypeID = new SelectList(db.IndustryTypes, "IndustryTypeID", "Type", industry.IndustryTypeID);
            return View(industry);
        }

        // GET: Industries/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Industry industry = await db.Industrys.FindAsync(id);
            if (industry == null)
            {
                return HttpNotFound();
            }
            return View(industry);
        }

        // POST: Industries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Industry industry = await db.Industrys.FindAsync(id);
            db.Industrys.Remove(industry);
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
    }
}
