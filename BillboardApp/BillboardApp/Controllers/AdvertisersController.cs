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
    public class AdvertisersController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Advertisers
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "";
            ViewBag.ContactSortParm = sortOrder == "Contact" ? "Contact_desc" : "Contact";
            ViewBag.EmailSortParm = sortOrder == "Email" ? "Email_desc" : "Email";
            ViewBag.PhoneNumberSortParm = sortOrder == "PhoneNumber" ? "PhoneNumber_desc" : "PhoneNumber";
            ViewBag.DetailSortParm = sortOrder == "Detail" ? "Detail_desc" : "Detail";

            IQueryable<AdvertiserViewModel> advertisersData = from advertisers in db.Advertisers
                                                        select new AdvertiserViewModel()
                                                            {
                                                                AdvertiserID = advertisers.AdvertiserID,
                                                                Name = advertisers.Name,
                                                                Contact = advertisers.Contact,
                                                                Email = advertisers.Email,
                                                                PhoneNumber = advertisers.PhoneNumber,
                                                                Detail = advertisers.Detail
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
                advertisersData = advertisersData.Where
                    (s => s.Name.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Name_desc":
                    advertisersData = advertisersData.OrderByDescending(s => s.Name);
                    break;
                case "Contact":
                    advertisersData = advertisersData.OrderBy(s => s.Contact);
                    break;
                case "Contact_desc":
                    advertisersData = advertisersData.OrderByDescending(s => s.Contact);
                    break;
                case "Email":
                    advertisersData = advertisersData.OrderBy(s => s.Email);
                    break;
                case "Email_desc":
                    advertisersData = advertisersData.OrderByDescending(s => s.Email);
                    break;
                case "PhoneNumber":
                    advertisersData = advertisersData.OrderBy(s => s.PhoneNumber);
                    break;
                case "PhoneNumber_desc":
                    advertisersData = advertisersData.OrderByDescending(s => s.PhoneNumber);
                    break;
                case "Detail":
                    advertisersData = advertisersData.OrderBy(s => s.Detail);
                    break;
                case "Detail_desc":
                    advertisersData = advertisersData.OrderByDescending(s => s.Detail);
                    break;
                default:
                    advertisersData = advertisersData.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await advertisersData.ToPagedListAsync(pageNumber, pageSize));

        }

        // GET: Advertisers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertiser advertiser = await db.Advertisers.FindAsync(id);
            if (advertiser == null)
            {
                return HttpNotFound();
            }
            return View(advertiser);
        }

        // GET: Advertisers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Advertisers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AdvertiserID,Name,Contact,Email,PhoneNumber,Detail")] Advertiser advertiser)
        {
            if (ModelState.IsValid)
            {
                db.Advertisers.Add(advertiser);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(advertiser);
        }

        // GET: Advertisers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertiser advertiser = await db.Advertisers.FindAsync(id);
            if (advertiser == null)
            {
                return HttpNotFound();
            }
            return View(advertiser);
        }

        // POST: Advertisers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AdvertiserID,Name,Contact,Email,PhoneNumber,Detail")] Advertiser advertiser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(advertiser).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(advertiser);
        }

        // GET: Advertisers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advertiser advertiser = await db.Advertisers.FindAsync(id);
            if (advertiser == null)
            {
                return HttpNotFound();
            }
            return View(advertiser);
        }

        // POST: Advertisers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Advertiser advertiser = await db.Advertisers.FindAsync(id);
            db.Advertisers.Remove(advertiser);
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
