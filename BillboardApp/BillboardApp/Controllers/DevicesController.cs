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
    public class DevicesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Devices
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "";
            ViewBag.IMEISortParm = sortOrder == "IMEI" ? "IMEI_desc" : "IMEI";
            ViewBag.SerialNoSortParm = sortOrder == "SerialNo" ? "SerialNo_desc" : "SerialNo";
            ViewBag.StatusSortParm = sortOrder == "Status" ? "Status_desc" : "Status";

            IQueryable<DeviceViewModel> devicesData = from devices in db.Devices.Include(d => d.DeviceStatus)
                                                          select new DeviceViewModel()
                                                              {
                                                                  DeviceID = devices.DeviceID,
                                                                  Name = devices.Name,
                                                                  IMEI = devices.IMEI,
                                                                  SerialNo = devices.SerialNo,
                                                                  Status = devices.DeviceStatus.Status
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
                devicesData = devicesData.Where
                    (s => s.IMEI.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.SerialNo.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Name_desc":
                    devicesData = devicesData.OrderByDescending(s => s.Name);
                    break;
                case "IMEI":
                    devicesData = devicesData.OrderBy(s => s.IMEI);
                    break;
                case "IMEI_desc":
                    devicesData = devicesData.OrderByDescending(s => s.IMEI);
                    break;
                case "SerialNo":
                    devicesData = devicesData.OrderBy(s => s.SerialNo);
                    break;
                case "SerialNo_desc":
                    devicesData = devicesData.OrderByDescending(s => s.SerialNo);
                    break;
                case "Status":
                    devicesData = devicesData.OrderBy(s => s.Status);
                    break;
                case "Status_desc":
                    devicesData = devicesData.OrderByDescending(s => s.Status);
                    break;
                default:
                    devicesData = devicesData.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await devicesData.ToPagedListAsync(pageNumber, pageSize));

        }

        // GET: Devices/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Device device = await db.Devices.FindAsync(id);
            if (device == null)
            {
                return HttpNotFound();
            }
            return View(device);
        }

        // GET: Devices/Create
        public ActionResult Create()
        {
            ViewBag.DeviceStatusID = new SelectList(db.DeviceStatuses, "DeviceStatusID", "Status");
            return View();
        }

        // POST: Devices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DeviceID,IMEI,Name,SerialNo,DeviceStatusID")] Device device)
        {
            if (ModelState.IsValid)
            {
                db.Devices.Add(device);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.DeviceStatusID = new SelectList(db.DeviceStatuses, "DeviceStatusID", "Status", device.DeviceStatusID);
            return View(device);
        }

        // GET: Devices/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Device device = await db.Devices.FindAsync(id);
            if (device == null)
            {
                return HttpNotFound();
            }
            ViewBag.DeviceStatusID = new SelectList(db.DeviceStatuses, "DeviceStatusID", "Status", device.DeviceStatusID);
            return View(device);
        }

        // POST: Devices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DeviceID,IMEI,Name,SerialNo,DeviceStatusID")] Device device)
        {
            if (ModelState.IsValid)
            {
                db.Entry(device).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.DeviceStatusID = new SelectList(db.DeviceStatuses, "DeviceStatusID", "Status", device.DeviceStatusID);
            return View(device);
        }

        // GET: Devices/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Device device = await db.Devices.FindAsync(id);
            if (device == null)
            {
                return HttpNotFound();
            }
            return View(device);
        }

        // POST: Devices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Device device = await db.Devices.FindAsync(id);
            db.Devices.Remove(device);
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
