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
    public class DeviceStatusController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: DeviceStatus
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Status_desc" : "";

            IQueryable<DeviceStatusViewModel> deviceStatusesData = from deviceStatuses in db.DeviceStatuses
                                                                select new DeviceStatusViewModel()
                                                              {
                                                                  DeviceStatusID = deviceStatuses.DeviceStatusID,
                                                                  Status = deviceStatuses.Status
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
                deviceStatusesData = deviceStatusesData.Where
                    (s => s.Status.ToString().ToUpper().Contains(searchString.ToUpper())
                    //|| s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Status_desc":
                    deviceStatusesData = deviceStatusesData.OrderByDescending(s => s.Status);
                    break;
                default:
                    deviceStatusesData = deviceStatusesData.OrderBy(s => s.Status);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await deviceStatusesData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: DeviceStatus/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceStatus deviceStatus = await db.DeviceStatuses.FindAsync(id);
            if (deviceStatus == null)
            {
                return HttpNotFound();
            }
            return View(deviceStatus);
        }

        // GET: DeviceStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeviceStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DeviceStatusID,Status")] DeviceStatus deviceStatus)
        {
            if (ModelState.IsValid)
            {
                db.DeviceStatuses.Add(deviceStatus);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(deviceStatus);
        }

        // GET: DeviceStatus/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceStatus deviceStatus = await db.DeviceStatuses.FindAsync(id);
            if (deviceStatus == null)
            {
                return HttpNotFound();
            }
            return View(deviceStatus);
        }

        // POST: DeviceStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DeviceStatusID,Status")] DeviceStatus deviceStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deviceStatus).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(deviceStatus);
        }

        // GET: DeviceStatus/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeviceStatus deviceStatus = await db.DeviceStatuses.FindAsync(id);
            if (deviceStatus == null)
            {
                return HttpNotFound();
            }
            return View(deviceStatus);
        }

        // POST: DeviceStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DeviceStatus deviceStatus = await db.DeviceStatuses.FindAsync(id);
            db.DeviceStatuses.Remove(deviceStatus);
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
