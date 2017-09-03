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
using BillboardApp.ViewModels;
using X.PagedList;

namespace BillboardApp.Controllers
{
    public class CampaignsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Campaigns
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.CampaignNameSortParm = String.IsNullOrEmpty(sortOrder) ? "CampaignName_desc" : "";
            ViewBag.AgencyNameSortParm = sortOrder == "AgencyName" ? "AgencyName_desc" : "AgencyName";
            ViewBag.ProductNameSortParm = sortOrder == "ProductName" ? "ProductName_desc" : "ProductName";

            IQueryable<CampaignViewModel> campaignsData = from campaigns in db.Campaigns.Include(c => c.Agency).Include(c => c.Product)
                                                          select new CampaignViewModel()
                                                              {
                                                                  CampaignID = campaigns.CampaignID,
                                                                  CampaignName = campaigns.CampaignName,
                                                                  AgencyName = campaigns.Agency.Name,
                                                                  ProductName = campaigns.Product.Name
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
                campaignsData = campaignsData.Where
                    (s => s.CampaignName.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.ProductName.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "CampaignName_desc":
                    campaignsData = campaignsData.OrderByDescending(s => s.CampaignName);
                    break;
                case "AgencyName":
                    campaignsData = campaignsData.OrderBy(s => s.AgencyName);
                    break;
                case "AgencyName_desc":
                    campaignsData = campaignsData.OrderByDescending(s => s.AgencyName);
                    break;
                case "ProductName":
                    campaignsData = campaignsData.OrderBy(s => s.ProductName);
                    break;
                case "ProductName_desc":
                    campaignsData = campaignsData.OrderByDescending(s => s.ProductName);
                    break;
                default:
                    campaignsData = campaignsData.OrderBy(s => s.CampaignName);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await campaignsData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: Campaigns/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campaign campaign = await db.Campaigns.FindAsync(id);
            if (campaign == null)
            {
                return HttpNotFound();
            }
            return View(campaign);
        }

        // GET: Campaigns/Create
        public ActionResult Create()
        {
            ViewBag.AgencyID = new SelectList(db.Agencys, "AgencyID", "Name");
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Name");
            return View();
        }

        // POST: Campaigns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CampaignID,CampaignName,ProductID,AgencyID")] Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                db.Campaigns.Add(campaign);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.AgencyID = new SelectList(db.Agencys, "AgencyID", "Name", campaign.AgencyID);
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Name", campaign.ProductID);
            return View(campaign);
        }

        // GET: Campaigns/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campaign campaign = await db.Campaigns.FindAsync(id);
            if (campaign == null)
            {
                return HttpNotFound();
            }
            ViewBag.AgencyID = new SelectList(db.Agencys, "AgencyID", "Name", campaign.AgencyID);
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Name", campaign.ProductID);
            return View(campaign);
        }

        // POST: Campaigns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CampaignID,CampaignName,ProductID,AgencyID")] Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                db.Entry(campaign).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.AgencyID = new SelectList(db.Agencys, "AgencyID", "Name", campaign.AgencyID);
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Name", campaign.ProductID);
            return View(campaign);
        }

        // GET: Campaigns/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Campaign campaign = await db.Campaigns.FindAsync(id);
            if (campaign == null)
            {
                return HttpNotFound();
            }
            return View(campaign);
        }

        // POST: Campaigns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Campaign campaign = await db.Campaigns.FindAsync(id);
            db.Campaigns.Remove(campaign);
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
