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

        //Give quote
        public ActionResult Quote(int id)
        {
            //instantiating Insuree class as insuree
            var insuree = db.Insurees.Find(id);
            //instantiating now as current year
            int now = DateTime.Now.Year;
            //instantiating db columns
            //getting insuree Year of Birth (YOB) converting it to an int data type 
            int YOB = Convert.ToInt32(insuree.DateOfBirth.Year);
            int insureeAge = now - YOB;
            int insureeCarYear = insuree.CarYear;
            string insureeCarMake = insuree.CarMake.ToLower();
            string insureeCarModel = insuree.CarModel.ToLower();
            int insureeTicket = Convert.ToInt32(insuree.SpeedingTickets);
            bool insureeDUI = insuree.DUI;
            bool fullCoverage = insuree.CoverageType;
            decimal baseQuote = 50.00m;

            //if statements that add to the baseQuote
            //Age
            if (insureeAge <= 18)
            {
                baseQuote += 100.00m;
            }
            else if (insureeAge >= 19 && insureeAge <= 25)
            {
                baseQuote += 50.00m;
            }
            //26 and above
            else
            {
                baseQuote += 25.00m;
            }

            //Car Year, excluding anything between 2000 and 2015
            if (insureeCarYear < 2000 || insureeCarYear > 2015)
            {
                baseQuote += 25.00m;
            }
            
            //Insuree Car Make and Model
            if (insureeCarMake == "porsche")
            {
                baseQuote += 25.00m;
                if (insureeCarModel == "911 carrera")
                {
                    baseQuote += 25.00m;
                }
            }

            //Insuree Tickets
            if (insureeTicket > 0)
            {
                baseQuote += insureeTicket * 10.00m;
            }

            //Insuree DUI
            if (insureeDUI)
            {
                baseQuote += baseQuote * .25m;
            }

            //insuree Coverage
            if (fullCoverage)
            {
                baseQuote += baseQuote * .5m; 
            }

            insuree.Quote = baseQuote;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                Quote(insuree.Id);
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
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
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

        // GET: Insuree/Admin
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }
    }
}
