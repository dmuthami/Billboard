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
    public class FacesController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Faces
        public async Task<ActionResult> Index()
        {
            var faces = db.Faces.Include(f => f.FaceAvailability).Include(f => f.FaceBound).Include(f => f.FaceCondition).Include(f => f.FaceOccupancy).Include(f => f.FaceOrientation).Include(f => f.FacePosition).Include(f => f.FaceSize).Include(f => f.FaceVisibilityRating).Include(f => f.Structure);
            return View(await faces.ToListAsync());
        }

        // GET: Faces/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Face face = await db.Faces.FindAsync(id);
            if (face == null)
            {
                return HttpNotFound();
            }
            return View(face);
        }

        // GET: Faces/Create
        public ActionResult Create()
        {
            ViewBag.FaceAvailabilityID = new SelectList(db.FaceAvailabilitys, "FaceAvailabilityID", "AvailabilityType");
            ViewBag.FaceBoundID = new SelectList(db.FaceBounds, "FaceBoundID", "Bound");
            ViewBag.FaceConditionID = new SelectList(db.FaceConditions, "FaceConditionID", "Condition");
            ViewBag.FaceOccupancyID = new SelectList(db.FaceOccupancys, "FaceOccupancyID", "Occupancy");
            ViewBag.FaceOrientationID = new SelectList(db.FaceOrientations, "FaceOrientationID", "Orientation");
            ViewBag.FacePositionID = new SelectList(db.FacePosition, "FacePositionID", "Position");
            ViewBag.FaceSizeID = new SelectList(db.FaceSize, "FaceSizeID", "FaceSizeID");
            ViewBag.FaceID = new SelectList(db.FaceVisibilityRatings, "FaceVisibilityRatingID", "FaceVisibilityRatingID");
            ViewBag.StructureID = new SelectList(db.Structures, "StructureID", "Comment");
            return View();
        }

        // POST: Faces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FaceID,FaceOccupancyID,FaceSizeID,FaceConditionID,FaceBoundID,FacePositionID,FaceAvailabilityID,StructureID,FaceOrientationID")] Face face)
        {
            if (ModelState.IsValid)
            {
                db.Faces.Add(face);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FaceAvailabilityID = new SelectList(db.FaceAvailabilitys, "FaceAvailabilityID", "AvailabilityType", face.FaceAvailabilityID);
            ViewBag.FaceBoundID = new SelectList(db.FaceBounds, "FaceBoundID", "Bound", face.FaceBoundID);
            ViewBag.FaceConditionID = new SelectList(db.FaceConditions, "FaceConditionID", "Condition", face.FaceConditionID);
            ViewBag.FaceOccupancyID = new SelectList(db.FaceOccupancys, "FaceOccupancyID", "Occupancy", face.FaceOccupancyID);
            ViewBag.FaceOrientationID = new SelectList(db.FaceOrientations, "FaceOrientationID", "Orientation", face.FaceOrientationID);
            ViewBag.FacePositionID = new SelectList(db.FacePosition, "FacePositionID", "Position", face.FacePositionID);
            ViewBag.FaceSizeID = new SelectList(db.FaceSize, "FaceSizeID", "FaceSizeID", face.FaceSizeID);
            ViewBag.FaceID = new SelectList(db.FaceVisibilityRatings, "FaceVisibilityRatingID", "FaceVisibilityRatingID", face.FaceID);
            ViewBag.StructureID = new SelectList(db.Structures, "StructureID", "Comment", face.StructureID);
            return View(face);
        }

        // GET: Faces/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Face face = await db.Faces.FindAsync(id);
            if (face == null)
            {
                return HttpNotFound();
            }
            ViewBag.FaceAvailabilityID = new SelectList(db.FaceAvailabilitys, "FaceAvailabilityID", "AvailabilityType", face.FaceAvailabilityID);
            ViewBag.FaceBoundID = new SelectList(db.FaceBounds, "FaceBoundID", "Bound", face.FaceBoundID);
            ViewBag.FaceConditionID = new SelectList(db.FaceConditions, "FaceConditionID", "Condition", face.FaceConditionID);
            ViewBag.FaceOccupancyID = new SelectList(db.FaceOccupancys, "FaceOccupancyID", "Occupancy", face.FaceOccupancyID);
            ViewBag.FaceOrientationID = new SelectList(db.FaceOrientations, "FaceOrientationID", "Orientation", face.FaceOrientationID);
            ViewBag.FacePositionID = new SelectList(db.FacePosition, "FacePositionID", "Position", face.FacePositionID);
            ViewBag.FaceSizeID = new SelectList(db.FaceSize, "FaceSizeID", "FaceSizeID", face.FaceSizeID);
            ViewBag.FaceID = new SelectList(db.FaceVisibilityRatings, "FaceVisibilityRatingID", "FaceVisibilityRatingID", face.FaceID);
            ViewBag.StructureID = new SelectList(db.Structures, "StructureID", "Comment", face.StructureID);
            return View(face);
        }

        // POST: Faces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FaceID,FaceOccupancyID,FaceSizeID,FaceConditionID,FaceBoundID,FacePositionID,FaceAvailabilityID,StructureID,FaceOrientationID")] Face face)
        {
            if (ModelState.IsValid)
            {
                db.Entry(face).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FaceAvailabilityID = new SelectList(db.FaceAvailabilitys, "FaceAvailabilityID", "AvailabilityType", face.FaceAvailabilityID);
            ViewBag.FaceBoundID = new SelectList(db.FaceBounds, "FaceBoundID", "Bound", face.FaceBoundID);
            ViewBag.FaceConditionID = new SelectList(db.FaceConditions, "FaceConditionID", "Condition", face.FaceConditionID);
            ViewBag.FaceOccupancyID = new SelectList(db.FaceOccupancys, "FaceOccupancyID", "Occupancy", face.FaceOccupancyID);
            ViewBag.FaceOrientationID = new SelectList(db.FaceOrientations, "FaceOrientationID", "Orientation", face.FaceOrientationID);
            ViewBag.FacePositionID = new SelectList(db.FacePosition, "FacePositionID", "Position", face.FacePositionID);
            ViewBag.FaceSizeID = new SelectList(db.FaceSize, "FaceSizeID", "FaceSizeID", face.FaceSizeID);
            ViewBag.FaceID = new SelectList(db.FaceVisibilityRatings, "FaceVisibilityRatingID", "FaceVisibilityRatingID", face.FaceID);
            ViewBag.StructureID = new SelectList(db.Structures, "StructureID", "Comment", face.StructureID);
            return View(face);
        }

        // GET: Faces/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Face face = await db.Faces.FindAsync(id);
            if (face == null)
            {
                return HttpNotFound();
            }
            return View(face);
        }

        // POST: Faces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Face face = await db.Faces.FindAsync(id);
            db.Faces.Remove(face);
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
