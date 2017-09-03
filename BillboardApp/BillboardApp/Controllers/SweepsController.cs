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
    public class SweepsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Sweeps
        public async Task<ActionResult> Index()
        {
            return View(await db.Sweeps.ToListAsync());
        }

        // GET: Sweeps/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sweep sweep = await db.Sweeps.FindAsync(id);
            if (sweep == null)
            {
                return HttpNotFound();
            }
            return View(sweep);
        }

        // GET: Sweeps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sweeps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SweepID,Name,Description,StartDate,EndDate")] Sweep sweep)
        {
            if (ModelState.IsValid)
            {
                db.Sweeps.Add(sweep);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sweep);
        }

        // GET: Sweeps/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sweep sweep = await db.Sweeps.FindAsync(id);
            if (sweep == null)
            {
                return HttpNotFound();
            }
            return View(sweep);
        }

        // POST: Sweeps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SweepID,Name,Description,StartDate,EndDate")] Sweep sweep)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sweep).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sweep);
        }

        // GET: Sweeps/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sweep sweep = await db.Sweeps.FindAsync(id);
            if (sweep == null)
            {
                return HttpNotFound();
            }
            return View(sweep);
        }

        // POST: Sweeps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Sweep sweep = await db.Sweeps.FindAsync(id);
            db.Sweeps.Remove(sweep);
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
