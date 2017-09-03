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
    public class FaceVisibilityRatingsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: FaceVisibilityRatings
        public async Task<ActionResult> Index()
        {
            var faceVisibilityRatings = db.FaceVisibilityRatings.Include(f => f.Face);
            return View(await faceVisibilityRatings.ToListAsync());
        }

        // GET: FaceVisibilityRatings/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceVisibilityRating faceVisibilityRating = await db.FaceVisibilityRatings.FindAsync(id);
            if (faceVisibilityRating == null)
            {
                return HttpNotFound();
            }
            return View(faceVisibilityRating);
        }

        // GET: FaceVisibilityRatings/Create
        public ActionResult Create()
        {
            ViewBag.FaceVisibilityRatingID = new SelectList(db.Faces, "FaceID", "FaceID");
            return View();
        }

        // POST: FaceVisibilityRatings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FaceVisibilityRatingID,VegetationCoverScore,SightLightingScore,BacklightScore,UnlightScore,TrafficScore,ClutterScore")] FaceVisibilityRating faceVisibilityRating)
        {
            if (ModelState.IsValid)
            {
                db.FaceVisibilityRatings.Add(faceVisibilityRating);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FaceVisibilityRatingID = new SelectList(db.Faces, "FaceID", "FaceID", faceVisibilityRating.FaceVisibilityRatingID);
            return View(faceVisibilityRating);
        }

        // GET: FaceVisibilityRatings/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceVisibilityRating faceVisibilityRating = await db.FaceVisibilityRatings.FindAsync(id);
            if (faceVisibilityRating == null)
            {
                return HttpNotFound();
            }
            ViewBag.FaceVisibilityRatingID = new SelectList(db.Faces, "FaceID", "FaceID", faceVisibilityRating.FaceVisibilityRatingID);
            return View(faceVisibilityRating);
        }

        // POST: FaceVisibilityRatings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FaceVisibilityRatingID,VegetationCoverScore,SightLightingScore,BacklightScore,UnlightScore,TrafficScore,ClutterScore")] FaceVisibilityRating faceVisibilityRating)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faceVisibilityRating).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FaceVisibilityRatingID = new SelectList(db.Faces, "FaceID", "FaceID", faceVisibilityRating.FaceVisibilityRatingID);
            return View(faceVisibilityRating);
        }

        // GET: FaceVisibilityRatings/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FaceVisibilityRating faceVisibilityRating = await db.FaceVisibilityRatings.FindAsync(id);
            if (faceVisibilityRating == null)
            {
                return HttpNotFound();
            }
            return View(faceVisibilityRating);
        }

        // POST: FaceVisibilityRatings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FaceVisibilityRating faceVisibilityRating = await db.FaceVisibilityRatings.FindAsync(id);
            db.FaceVisibilityRatings.Remove(faceVisibilityRating);
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
