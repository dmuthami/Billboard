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
    public class FaceImagesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: FaceImages
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var faceImages = db.FaceImages.Include(f => f.Face);
            //return View(await faceImages.ToListAsync());

            ViewBag.ImageSortParm = String.IsNullOrEmpty(sortOrder) ? "Image_desc" : "";
            ViewBag.TimeStampSortParm = sortOrder == "TimeStamp" ? "TimeStamp_desc" : "TimeStamp";


            IQueryable<FaceImageViewModel> faceImagesData = from faceImages in db.FaceImages.Include(f => f.Face)
                                                             select new FaceImageViewModel()
                                                              {
                                                                  FaceImageID = faceImages.FaceImageID,
                                                                  FaceURL = faceImages.FaceURL,
                                                                  Content = faceImages.Content,
                                                                  TimeStamp = faceImages.TimeStamp
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
                faceImagesData = faceImagesData.Where
                    (s => s.FaceURL.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.TimeStamp.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Image_desc":
                    faceImagesData = faceImagesData.OrderByDescending(s => s.FaceURL);
                    break;
                case "TimeStamp":
                    faceImagesData = faceImagesData.OrderBy(s => s.TimeStamp);
                    break;
                case "TimeStamp_desc":
                    faceImagesData = faceImagesData.OrderByDescending(s => s.TimeStamp);
                    break;
                default:
                    faceImagesData = faceImagesData.OrderBy(s => s.FaceURL);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await faceImagesData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: FaceImages/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceImage faceImage = await db.FaceImages.FindAsync(id);
            if (faceImage == null)
            {
                return HttpNotFound();
            }
            return View(faceImage);
        }

        // GET: FaceImages/Create
        public ActionResult Create()
        {
            ViewBag.FaceID = new SelectList(db.Faces, "FaceID", "FaceID");
            return View();
        }

        // POST: FaceImages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FaceImageID,FaceURL,Content,TimeStamp,FaceID")] FaceImage faceImage)
        {
            if (ModelState.IsValid)
            {
                db.FaceImages.Add(faceImage);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FaceID = new SelectList(db.Faces, "FaceID", "FaceID", faceImage.FaceID);
            return View(faceImage);
        }

        // GET: FaceImages/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceImage faceImage = await db.FaceImages.FindAsync(id);
            if (faceImage == null)
            {
                return HttpNotFound();
            }
            ViewBag.FaceID = new SelectList(db.Faces, "FaceID", "FaceID", faceImage.FaceID);
            return View(faceImage);
        }

        // POST: FaceImages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FaceImageID,FaceURL,Content,TimeStamp,FaceID")] FaceImage faceImage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faceImage).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FaceID = new SelectList(db.Faces, "FaceID", "FaceID", faceImage.FaceID);
            return View(faceImage);
        }

        // GET: FaceImages/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceImage faceImage = await db.FaceImages.FindAsync(id);
            if (faceImage == null)
            {
                return HttpNotFound();
            }
            return View(faceImage);
        }

        // POST: FaceImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FaceImage faceImage = await db.FaceImages.FindAsync(id);
            db.FaceImages.Remove(faceImage);
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
