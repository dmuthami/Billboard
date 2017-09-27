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
using System.Data.Entity.Infrastructure;

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
            ViewBag.AdvertiserNameSortParm = sortOrder == "AdvertiserName" ? "AdvertiserName_desc" : "AdvertiserName";
            ViewBag.IndustryNameSortParm = sortOrder == "IndustryName" ? "IndustryName_desc" : "IndustryName";
            IQueryable<CampaignViewModel> campaignsData = from campaigns in db.Campaigns.Include(c => c.Agency)
                                                              .Include(c => c.Advertiser)
                                                                .Include(c => c.Industry)
                                                          select new CampaignViewModel()
                                                          {
                                                              CampaignID = campaigns.CampaignID,
                                                              CampaignName = campaigns.CampaignName,
                                                              AgencyName = campaigns.Agency.Name
                                                              ,
                                                              AdvertiserName = campaigns.Advertiser.Name
                                                              ,
                                                              IndustryName = campaigns.Industry.Name
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
                    || s.AdvertiserName.ToString().ToUpper().Contains(searchString.ToUpper())
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
                case "AdvertiserName":
                    campaignsData = campaignsData.OrderBy(s => s.AdvertiserName);
                    break;
                case "AdvertiserName_desc":
                    campaignsData = campaignsData.OrderByDescending(s => s.AdvertiserName);
                    break;
                case "IndustryName":
                    campaignsData = campaignsData.OrderBy(s => s.IndustryName);
                    break;
                case "IndustryName_desc":
                    campaignsData = campaignsData.OrderByDescending(s => s.IndustryName);
                    break;
                default:
                    campaignsData = campaignsData.OrderBy(s => s.CampaignName);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await campaignsData.ToPagedListAsync(pageNumber, pageSize));
        }

        public async Task<ActionResult> Details(int? id)
        {
            var viewModel = new CampaignDetailData();

            viewModel.Campaigns = await db.Campaigns
                .Include(a => a.Advertiser)
                .Include(i => i.Routes)
                .OrderBy(i => i.CampaignName)
                .ToListAsync();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                ViewBag.CampaignID = id.Value;
                viewModel.Routes = viewModel.Campaigns.Where(i => i.CampaignID == id.Value)
                    .Single().Routes;
                viewModel.Campaign = viewModel.Campaigns.Where(i => i.CampaignID == id.Value).Single();
            }

            //if (campaign == null)
            //{
            //    return HttpNotFound();
            //}
            return View(viewModel);
        }
        // GET: Campaigns/Create
        public ActionResult Create()
        {
            ViewBag.AgencyID = new SelectList(db.Agencys, "AgencyID", "Name");
            ViewBag.AdvertiserID = new SelectList(db.Advertisers, "AdvertiserID", "Name");
            ViewBag.IndustryID = new SelectList(db.Industrys, "IndustryID", "Name");
            return View();
        }

        // POST: Campaigns/Createfic properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId3=
        // To protect from overposting attacks, please enable the speci17598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CampaignID,CampaignName,AgencyID,AdvertiserID,IndustryID")] Campaign campaign)
        {
            if (ModelState.IsValid)
            {
                db.Campaigns.Add(campaign);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.AgencyID = new SelectList(db.Agencys, "AgencyID", "Name", campaign.AgencyID);
            ViewBag.AdvertiserID = new SelectList(db.Advertisers, "AdvertiserID", "Name", campaign.AdvertiserID);
            ViewBag.IndustryID = new SelectList(db.Industrys, "IndustryID", "Name", campaign.IndustryID);
            return View(campaign);
        }

        // GET: Campaigns/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Campaign campaign = await db.Campaigns
                                .Include(a => a.Advertiser)
                                .Include(r => r.Routes)
                                .AsNoTracking()
                                .SingleOrDefaultAsync(i => i.CampaignID == id);
            PopulateAssignedRouteData(campaign);

            if (campaign == null)
            {
                return HttpNotFound();
            }
            ViewBag.AgencyID = new SelectList(db.Agencys, "AgencyID", "Name", campaign.AgencyID);
            ViewBag.AdvertiserID = new SelectList(db.Advertisers, "AdvertiserID", "Name", campaign.AdvertiserID);
            ViewBag.IndustryID = new SelectList(db.Industrys, "IndustryID", "Name", campaign.IndustryID);

            return View(campaign);
        }
        private void PopulateAssignedRouteData(Campaign campaign)
        {
            var allRoutes = db.Routes;
            var campaignRoutes = new HashSet<int>(campaign.Routes.Select(c => c.RouteID));
            var viewModel = new List<AssignedRoutesData>();
            foreach (var route in allRoutes)
            {
                viewModel.Add(new AssignedRoutesData
                {

                    RouteID = route.RouteID,
                    Name = route.Name,
                    Assigned = campaignRoutes.Contains(route.RouteID)
                });
            }
            ViewBag.Routes = viewModel;
        }
        // POST: Campaigns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int? id, string[] selectedRoutes)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var campaignToUpdate = db.Campaigns
                                .Include(i => i.Advertiser)
                                .Include(i => i.Routes)
                                .Where(i => i.CampaignID == id.Value)
                                .Single();

            if (TryUpdateModel<Campaign>(
                campaignToUpdate,
                "",
                new string[] { "CampaignID", "CampaignName", "IndustryID", "AgencyID", "AdvertiserID" }
                ))
            {

                UpdateCampaignRoutes(selectedRoutes, campaignToUpdate);
                try
                {
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
                UpdateCampaignRoutes(selectedRoutes, campaignToUpdate);
                PopulateAssignedRouteData(campaignToUpdate);
                return RedirectToAction("Index");
            }
            return View(campaignToUpdate);

        }

        private void UpdateCampaignRoutes(string[] selectedRoutes, Campaign campaignToUpdate)
        {
            if (selectedRoutes == null)
            {
                campaignToUpdate.Routes = new List<Route>();
                return;
            }

            var selectedRoutesHS = new HashSet<string>(selectedRoutes);
            var instructorRoutes = new HashSet<int>
                (campaignToUpdate.Routes.Select(c => c.RouteID));
            foreach (var route in db.Routes)
            {
                if (selectedRoutesHS.Contains(route.RouteID.ToString()))
                {
                    if (!instructorRoutes.Contains(route.RouteID))
                    {
                        campaignToUpdate.Routes.Add(route);
                    }
                }
                else
                {
                    if (instructorRoutes.Contains(route.RouteID))
                    {
                        campaignToUpdate.Routes.Remove(route);
                    }
                }
            }
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
