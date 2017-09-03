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
    public class CampaignRoutesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: CampaignRoutes
        public async Task<ActionResult> Index()
        {
            var campaignRoutes = db.CampaignRoutes.Include(c => c.Campaign).Include(c => c.Route);
            return View(await campaignRoutes.ToListAsync());
        }

        // GET: CampaignRoutes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CampaignRoute campaignRoute = await db.CampaignRoutes.FindAsync(id);
            if (campaignRoute == null)
            {
                return HttpNotFound();
            }
            return View(campaignRoute);
        }

        // GET: CampaignRoutes/Create
        public ActionResult Create()
        {
            ViewBag.CampaignID = new SelectList(db.Campaigns, "CampaignID", "CampaignName");
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "Name");
            return View();
        }

        // POST: CampaignRoutes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CampaignRouteID,CampaignID,RouteID")] CampaignRoute campaignRoute)
        {
            if (ModelState.IsValid)
            {
                db.CampaignRoutes.Add(campaignRoute);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CampaignID = new SelectList(db.Campaigns, "CampaignID", "CampaignName", campaignRoute.CampaignID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "Name", campaignRoute.RouteID);
            return View(campaignRoute);
        }

        // GET: CampaignRoutes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CampaignRoute campaignRoute = await db.CampaignRoutes.FindAsync(id);
            if (campaignRoute == null)
            {
                return HttpNotFound();
            }
            ViewBag.CampaignID = new SelectList(db.Campaigns, "CampaignID", "CampaignName", campaignRoute.CampaignID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "Name", campaignRoute.RouteID);
            return View(campaignRoute);
        }

        // POST: CampaignRoutes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CampaignRouteID,CampaignID,RouteID")] CampaignRoute campaignRoute)
        {
            if (ModelState.IsValid)
            {
                db.Entry(campaignRoute).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CampaignID = new SelectList(db.Campaigns, "CampaignID", "CampaignName", campaignRoute.CampaignID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "Name", campaignRoute.RouteID);
            return View(campaignRoute);
        }

        // GET: CampaignRoutes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CampaignRoute campaignRoute = await db.CampaignRoutes.FindAsync(id);
            if (campaignRoute == null)
            {
                return HttpNotFound();
            }
            return View(campaignRoute);
        }

        // POST: CampaignRoutes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CampaignRoute campaignRoute = await db.CampaignRoutes.FindAsync(id);
            db.CampaignRoutes.Remove(campaignRoute);
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
