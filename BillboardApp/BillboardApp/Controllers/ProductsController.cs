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
    public class ProductsController : Controller
    {
        private BillboardContext db = new BillboardContext();

        // GET: Products
        public async Task<ActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //var products = db.Products.Include(p => p.Advertiser);
            //return View(await products.ToListAsync());

            ViewBag.ProductNameSortParm = String.IsNullOrEmpty(sortOrder) ? "ProductName_desc" : "";
            ViewBag.AdvertiserNameSortParm = sortOrder == "AdvertiserName" ? "AdvertiserName_desc" : "AdvertiserName";

            IQueryable<ProductViewModel> productsData = from products in db.Products.Include(p => p.Advertiser)
                                                        select new ProductViewModel()
                                                        {
                                                            ProductID = products.ProductID,
                                                            ProductName = products.Name,
                                                            AdvertiserName = products.Advertiser.Name
                                                        };
            //Paging
            if (searchString != null)
            {
                page = 1;
            }
            else { searchString = currentFilter;}

            ViewBag.CurrentFilter = searchString;

            //Filtering
            if (!String.IsNullOrEmpty(searchString))
            {
                productsData = productsData.Where
                    (s => s.ProductName.ToString().ToUpper().Contains(searchString.ToUpper())
                    || s.AdvertiserName.ToString().ToUpper().Contains(searchString.ToUpper())
                    );
            }
            switch (sortOrder)
            {
                case "ProductName_desc":
                    productsData = productsData.OrderByDescending(s => s.ProductName);
                    break;
                case "AdvertiserName_desc":
                    productsData = productsData.OrderByDescending(s => s.ProductName);
                    break;
                case "AdvertiserName":
                    productsData = productsData.OrderBy(s => s.ProductName);
                    break;
                default:
                    productsData = productsData.OrderBy(s => s.ProductName);
                    break;
            }
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            return View(await productsData.ToPagedListAsync(pageNumber, pageSize));
        }

        // GET: Products/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.AdvertiserID = new SelectList(db.Advertisers, "AdvertiserID", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ProductID,Name,AdvertiserID")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.AdvertiserID = new SelectList(db.Advertisers, "AdvertiserID", "Name", product.AdvertiserID);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdvertiserID = new SelectList(db.Advertisers, "AdvertiserID", "Name", product.AdvertiserID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProductID,Name,AdvertiserID")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.AdvertiserID = new SelectList(db.Advertisers, "AdvertiserID", "Name", product.AdvertiserID);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Product product = await db.Products.FindAsync(id);
            db.Products.Remove(product);
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
