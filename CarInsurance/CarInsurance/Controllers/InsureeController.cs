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

        public double CalculateQuote(Insuree insuree)
        {
            // Start with a base of $50/month
            double quote = 50;

            // Calculate age based on the DateOfBirth property
            int clientAge = DateTime.Now.Year - insuree.DateofBirth.Year;

            // Apply age-based adjustments to the quote
            if (clientAge <= 18)
            {
                quote += 100; // Add $100/month for users 18 or younger
            }
            else if (clientAge <= 25)
            {
                quote += 50; // Add $50/month for users aged 19 to 25
            }
            else
            {
                quote += 25; // Add $25/month for users 26 or older
            }

            // Adjust quote based on other factors
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
            {
                quote += 25; // Add $25/month for car years outside the range
            }

            if (insuree.CarMake == "Porsche")
            {
                quote += 25; // Add $25/month for Porsche make

                if (insuree.CarModel == "911 Carrera")
                {
                    quote += 25; // Add an additional $25/month for 911 Carrera model
                }
            }

            quote += 10 * insuree.SpeedingTicket; // Add $10/month per speeding ticket

            if (insuree.DUI)
            {
                quote *= 1.25; // Increase the quote by 25% for DUI
            }

            if (insuree.CoverageType)
            {
                quote *= 1.5; // Increase the quote by 50% for full coverage
            }

            return quote;
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
