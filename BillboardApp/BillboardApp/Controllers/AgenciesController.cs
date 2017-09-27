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
    public class AgenciesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Agencies
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            //return View(await agencys.ToListAsync());

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "";
            ViewBag.ContactPersonSortParm = sortOrder == "ContactPerson" ? "ContactPerson_desc" : "ContactPerson";
            ViewBag.EmailSortParm = sortOrder == "Email" ? "Email_desc" : "Email";
            ViewBag.PhoneNumberSortParm = sortOrder == "Phone" ? "Phone_desc" : "Phone";
            //ViewBag.SubscriptionSortParm = sortOrder == "Subscription" ? "Subscription_desc" : "Subscription";
            ViewBag.AmountSortParm = sortOrder == "Amount" ? "Amount_desc" : "Amount";
            ViewBag.PaidSortParm = sortOrder == "Paid" ? "Paid_desc" : "Paid";

            IQueryable<AgencyViewModel> agencysData = from agencys in db.Agencys.Include(a => a.Subscription)
                                                      select new AgencyViewModel()
                                                              {
                                                                  AgencyID = agencys.AgencyID,
                                                                  Name = agencys.Name,
                                                                  ContactPerson = agencys.ContactPerson,
                                                                  Email = agencys.Email,
                                                                  Phone = agencys.Phone,
                                                                  //Subscription = agencys.Subscription.Name,
                                                                  Amount = agencys.Subscription.Amount,
                                                                  Paid = agencys.Subscription.Paid
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
                agencysData = agencysData.Where
                    (s => s.Name.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.ContactPerson.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Name_desc":
                    agencysData = agencysData.OrderByDescending(s => s.Name);
                    break;
                case "ContactPerson":
                    agencysData = agencysData.OrderBy(s => s.ContactPerson);
                    break;
                case "ContactPerson_desc":
                    agencysData = agencysData.OrderByDescending(s => s.ContactPerson);
                    break;
                case "Email":
                    agencysData = agencysData.OrderBy(s => s.Email);
                    break;
                case "Email_desc":
                    agencysData = agencysData.OrderByDescending(s => s.Email);
                    break;
                case "Phone":
                    agencysData = agencysData.OrderBy(s => s.Phone);
                    break;
                case "Phone_desc":
                    agencysData = agencysData.OrderByDescending(s => s.Phone);
                    break;
                //case "Subscription":
                //    agencysData = agencysData.OrderBy(s => s.Subscription);
                //    break;
                //case "Subscription_desc":
                //    agencysData = agencysData.OrderByDescending(s => s.Subscription);
                //    break;
                case "Amount":
                    agencysData = agencysData.OrderBy(s => s.Amount);
                    break;
                case "Amount_desc":
                    agencysData = agencysData.OrderByDescending(s => s.Amount);
                    break;
                case "Paid":
                    agencysData = agencysData.OrderBy(s => s.Paid);
                    break;
                case "Paid_desc":
                    agencysData = agencysData.OrderByDescending(s => s.Paid);
                    break;
                default:
                    agencysData = agencysData.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await agencysData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: Agencies/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agency agency = await db.Agencys.FindAsync(id);

            if (agency == null)
            {
                return HttpNotFound();
            }
            ViewBag.id = id;
            return View(agency);
        }

        // GET: Agencies/Create
        public ActionResult Create()
        {
            ViewBag.AgencyID = new SelectList(db.Subscriptions, "SubscriptionID", "Name");

            return View();
        }

        public ActionResult CreateAgencyWithSubscription()
        {
            AgencyIndexViewModel agencyIndexViewModel = new AgencyIndexViewModel();
            return View(agencyIndexViewModel);
        }

        // POST: Agencies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AgencyID,Name,ContactPerson,Email,Phone")] Agency agency)
        {
            if (ModelState.IsValid)
            {
                db.Agencys.Add(agency);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.AgencyID = new SelectList(db.Subscriptions, "SubscriptionID", "Name", agency.AgencyID);
            return View(agency);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAgencyWithSubscription([Bind(Include = "AgencyID,Name,ContactPerson,Email,Phone")] Agency agency,
            [Bind(Include = "SubscriptionID,Amount,Paid,StartDate,ExpiryDate,Description")] Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                db.Agencys.Add(agency);
                db.Subscriptions.Add(subscription);

                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.AgencyID = new SelectList(db.Subscriptions, "SubscriptionID", "Name", agency.AgencyID);
            return View(agency);
        }

        // GET: Agencies/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agency agency = await db.Agencys.FindAsync(id);
            if (agency == null)
            {
                return HttpNotFound();
            }
            ViewBag.AgencyID = new SelectList(db.Subscriptions, "SubscriptionID", "Name", agency.AgencyID);
            return View(agency);
        }

        // POST: Agencies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AgencyID,Name,ContactPerson,Email,Phone")] Agency agency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agency).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.AgencyID = new SelectList(db.Subscriptions, "SubscriptionID", "Name", agency.AgencyID);
            return View(agency);
        }

        // GET: Agencies/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Agency agency = await db.Agencys.FindAsync(id);
            if (agency == null)
            {
                return HttpNotFound();
            }
            return View(agency);
        }

        // POST: Agencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            //Subscription subscription = await db.Subscriptions.FindAsync(1d);
            Agency agency = await db.Agencys.FindAsync(id);

            //db.Subscriptions.Remove(subscription);
            db.Agencys.Remove(agency);
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
