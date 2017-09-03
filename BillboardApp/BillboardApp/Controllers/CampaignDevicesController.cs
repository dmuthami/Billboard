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
    public class CampaignDevicesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: CampaignDevices
        public async Task<ActionResult> Index()
        {
            var campaignDevices = db.CampaignDevices.Include(c => c.Campaign).Include(c => c.Device);
            return View(await campaignDevices.ToListAsync());
        }

        // GET: CampaignDevices/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CampaignDevice campaignDevice = await db.CampaignDevices.FindAsync(id);
            if (campaignDevice == null)
            {
                return HttpNotFound();
            }
            return View(campaignDevice);
        }

        // GET: CampaignDevices/Create
        public ActionResult Create()
        {
            ViewBag.CampaignID = new SelectList(db.Campaigns, "CampaignID", "CampaignName");
            ViewBag.DeviceID = new SelectList(db.Devices, "DeviceID", "IMEI");
            return View();
        }

        // POST: CampaignDevices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CampaignDeviceID,CampaignID,DeviceID")] CampaignDevice campaignDevice)
        {
            if (ModelState.IsValid)
            {
                db.CampaignDevices.Add(campaignDevice);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CampaignID = new SelectList(db.Campaigns, "CampaignID", "CampaignName", campaignDevice.CampaignID);
            ViewBag.DeviceID = new SelectList(db.Devices, "DeviceID", "IMEI", campaignDevice.DeviceID);
            return View(campaignDevice);
        }

        // GET: CampaignDevices/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CampaignDevice campaignDevice = await db.CampaignDevices.FindAsync(id);
            if (campaignDevice == null)
            {
                return HttpNotFound();
            }
            ViewBag.CampaignID = new SelectList(db.Campaigns, "CampaignID", "CampaignName", campaignDevice.CampaignID);
            ViewBag.DeviceID = new SelectList(db.Devices, "DeviceID", "IMEI", campaignDevice.DeviceID);
            return View(campaignDevice);
        }

        // POST: CampaignDevices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CampaignDeviceID,CampaignID,DeviceID")] CampaignDevice campaignDevice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(campaignDevice).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CampaignID = new SelectList(db.Campaigns, "CampaignID", "CampaignName", campaignDevice.CampaignID);
            ViewBag.DeviceID = new SelectList(db.Devices, "DeviceID", "IMEI", campaignDevice.DeviceID);
            return View(campaignDevice);
        }

        // GET: CampaignDevices/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CampaignDevice campaignDevice = await db.CampaignDevices.FindAsync(id);
            if (campaignDevice == null)
            {
                return HttpNotFound();
            }
            return View(campaignDevice);
        }

        // POST: CampaignDevices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CampaignDevice campaignDevice = await db.CampaignDevices.FindAsync(id);
            db.CampaignDevices.Remove(campaignDevice);
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
