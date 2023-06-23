using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAdress,DateofBirth,CarYear,CarModel,CarMake,DUI,SpeedingTicket,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAdress,DateofBirth,CarYear,CarModel,CarMake,DUI,SpeedingTicket,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
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

        public ActionResult CalculateQuote(Insuree insuree)
        {
            decimal baseQuote = 50m;
            decimal totalQuote = baseQuote;

            // Age factor
            if (insuree.Age <= 18)
            {
                totalQuote += 100m;
            }
            else if (insuree.Age >= 19 && insuree.Age <= 25)
            {
                totalQuote += 50m;
            }
            else
            {
                totalQuote += 25m;
            }

            // Car year factor
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)

            {
                totalQuote += 25m;
            }

            // Car make and model factors
            if (insuree.CarMake == "Porsche")
            {
                totalQuote += 25m;

                if (insuree.CarModel == "911 Carrera")
                {
                    totalQuote += 25m;
                }
            }

            // Speeding tickets factor
            totalQuote += 10m * insuree.SpeedingTickets;

            // DUI factor
            if (insuree.HasDUI)
            {
                totalQuote *= 1.25m;
            }

            // Coverage factor
            if (insuree.CoverageType == "Full")
            {
                totalQuote *= 1.5m;
            }

            // Round the quote to 2 decimal places
            totalQuote = Math.Round(totalQuote, 2);

            // Pass the calculated quote to the View
            ViewBag.Quote = totalQuote;
            return View();
        }

        public ActionResult Admin()
        {
            using (var context = new InsuranceEntities()) // Replace YourDbContext with your actual DbContext class name
            {
                var quotes = context.Insurees.ToList();
                return View(quotes);
            }
        }








    }
}
