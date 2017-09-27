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
    public class StructuresController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Structures
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var structures = db.Structures.Include(s => s.StructureOwner).Include(s => s.StructureType);
            //return View(await structures.ToListAsync());

            //why didnt it load

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "";
            ViewBag.TypeSortParm = sortOrder == "Type" ? "Type_desc" : "Type";
            ViewBag.FaceCountSortParm = sortOrder == "FaceCount" ? "FaceCount_desc" : "FaceCount";
            ViewBag.CommentSortParm = sortOrder == "Comment" ? "Comment_desc" : "Comment";
            ViewBag.LatitudeSortParm = sortOrder == "Latitude" ? "Latitude_desc" : "Latitude";
            ViewBag.LongitudeSortParm = sortOrder == "Longitude" ? "Longitude_desc" : "Longitude";

            IQueryable<StructureViewModel> structuresData = from structures in db.Structures.Include(s => s.StructureOwner).Include(s => s.StructureType)
                                                            select new StructureViewModel()
                                                              {
                                                                  StructureID = structures.StructureID,
                                                                  Name = structures.StructureOwner.Name,
                                                                  Type = structures.StructureType.Type,
                                                                  FaceCount = structures.FaceCount,
                                                                  Comment = structures.Comment,
                                                                  Latitude = structures.Latitude,
                                                                  Longitude = structures.Longitude,
                                                                  Ward = structures.Ward,
                                                                  Constituency = structures.Constituency,
                                                                  County = structures.County

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
                structuresData = structuresData.Where
                    (s => s.Name.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.Type.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "Name_desc":
                    structuresData = structuresData.OrderByDescending(s => s.Name);
                    break;
                case "Type":
                    structuresData = structuresData.OrderBy(s => s.Type);
                    break;
                case "Type_desc":
                    structuresData = structuresData.OrderByDescending(s => s.Type);
                    break;
                case "FaceCount":
                    structuresData = structuresData.OrderBy(s => s.FaceCount);
                    break;
                case "FaceCount_desc":
                    structuresData = structuresData.OrderByDescending(s => s.FaceCount);
                    break;
                case "Comment":
                    structuresData = structuresData.OrderBy(s => s.Comment);
                    break;
                case "Comment_desc":
                    structuresData = structuresData.OrderByDescending(s => s.Comment);
                    break;
                case "Latitude":
                    structuresData = structuresData.OrderBy(s => s.Latitude);
                    break;
                case "Latitude_desc":
                    structuresData = structuresData.OrderByDescending(s => s.Latitude);
                    break;
                default:
                    structuresData = structuresData.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await structuresData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: Structures/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Structure structure = await db.Structures.FindAsync(id);
            if (structure == null)
            {
                return HttpNotFound();
            }
            return View(structure);
        }

        // GET: Structures/Create
        public ActionResult Create()
        {
            ViewBag.StructureOwnerID = new SelectList(db.StructureOwners, "StructureOwnerID", "Name");
            ViewBag.StructureTypeID = new SelectList(db.StructureTypes, "StructureTypeID", "Type");
            return View();
        }

        // POST: Structures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "StructureID,FaceCount,Comment,Latitude,Longitude,StructureTypeID,StructureOwnerID")] Structure structure)
        {
            if (ModelState.IsValid)
            {
                db.Structures.Add(structure);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.StructureOwnerID = new SelectList(db.StructureOwners, "StructureOwnerID", "Name", structure.StructureOwnerID);
            ViewBag.StructureTypeID = new SelectList(db.StructureTypes, "StructureTypeID", "Type", structure.StructureTypeID);
            return View(structure);
        }

        // GET: Structures/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Structure structure = await db.Structures.FindAsync(id);
            if (structure == null)
            {
                return HttpNotFound();
            }
            ViewBag.StructureOwnerID = new SelectList(db.StructureOwners, "StructureOwnerID", "Name", structure.StructureOwnerID);
            ViewBag.StructureTypeID = new SelectList(db.StructureTypes, "StructureTypeID", "Type", structure.StructureTypeID);
            return View(structure);
        }

        // POST: Structures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "StructureID,FaceCount,Comment,Latitude,Longitude,StructureTypeID,StructureOwnerID")] Structure structure)
        {
            if (ModelState.IsValid)
            {
                db.Entry(structure).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.StructureOwnerID = new SelectList(db.StructureOwners, "StructureOwnerID", "Name", structure.StructureOwnerID);
            ViewBag.StructureTypeID = new SelectList(db.StructureTypes, "StructureTypeID", "Type", structure.StructureTypeID);
            return View(structure);
        }

        // GET: Structures/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Structure structure = await db.Structures.FindAsync(id);
            if (structure == null)
            {
                return HttpNotFound();
            }
            return View(structure);
        }

        // POST: Structures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Structure structure = await db.Structures.FindAsync(id);
            db.Structures.Remove(structure);
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
