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
    public class FaceSizesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: FaceSizes
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.SizeSortParm = String.IsNullOrEmpty(sortOrder) ? "Size_desc" : "";

            IQueryable<FaceSizeViewModel> faceSizeData = from faceSize in db.FaceSize
                                                            select new FaceSizeViewModel()
                                                              {
                                                                  FaceSizeID = faceSize.FaceSizeID,
                                                                  Size = faceSize.Size
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
                faceSizeData = faceSizeData.Where
                    (s => s.Size.ToString().ToUpper().Contains(searchString.ToUpper())
                    //|| s.PhoneNumber.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Size_desc":
                    faceSizeData = faceSizeData.OrderByDescending(s => s.Size);
                    break;
                default:
                    faceSizeData = faceSizeData.OrderBy(s => s.Size);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await faceSizeData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: FaceSizes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceSize faceSize = await db.FaceSize.FindAsync(id);
            if (faceSize == null)
            {
                return HttpNotFound();
            }
            return View(faceSize);
        }

        // GET: FaceSizes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FaceSizes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FaceSizeID,Size")] FaceSize faceSize)
        {
            if (ModelState.IsValid)
            {
                db.FaceSize.Add(faceSize);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(faceSize);
        }

        // GET: FaceSizes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceSize faceSize = await db.FaceSize.FindAsync(id);
            if (faceSize == null)
            {
                return HttpNotFound();
            }
            return View(faceSize);
        }

        // POST: FaceSizes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FaceSizeID,Size")] FaceSize faceSize)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faceSize).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(faceSize);
        }

        // GET: FaceSizes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceSize faceSize = await db.FaceSize.FindAsync(id);
            if (faceSize == null)
            {
                return HttpNotFound();
            }
            return View(faceSize);
        }

        // POST: FaceSizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FaceSize faceSize = await db.FaceSize.FindAsync(id);
            db.FaceSize.Remove(faceSize);
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
