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

namespace BillboardApp.Controllers
{
    public class BacklightsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Backlights
        public async Task<ActionResult> Index()
        {
            return View(await db.Backlights.ToListAsync());
        }

        // GET: Backlights/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Backlight backlight = await db.Backlights.FindAsync(id);
            if (backlight == null)
            {
                return HttpNotFound();
            }
            return View(backlight);
        }

        // GET: Backlights/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Backlights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "BacklightID,Parameter,Score")] Backlight backlight)
        {
            if (ModelState.IsValid)
            {
                db.Backlights.Add(backlight);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(backlight);
        }

        // GET: Backlights/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Backlight backlight = await db.Backlights.FindAsync(id);
            if (backlight == null)
            {
                return HttpNotFound();
            }
            return View(backlight);
        }

        // POST: Backlights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "BacklightID,Parameter,Score")] Backlight backlight)
        {
            if (ModelState.IsValid)
            {
                db.Entry(backlight).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(backlight);
        }

        // GET: Backlights/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Backlight backlight = await db.Backlights.FindAsync(id);
            if (backlight == null)
            {
                return HttpNotFound();
            }
            return View(backlight);
        }

        // POST: Backlights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Backlight backlight = await db.Backlights.FindAsync(id);
            db.Backlights.Remove(backlight);
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
