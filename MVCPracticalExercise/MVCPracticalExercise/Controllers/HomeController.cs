using MVCPracticalExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPracticalExercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       [HttpPost]
       public ActionResult Admin(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
                                    int carYear, string carMake, string carModel, int speedingTickets,
                                    string radioDui, string radioCoverage)
       {
            decimal quote = 50m;
            int userAge = Convert.ToInt32(DateTime.Now.Year - dateOfBirth.Year);

            ViewBag.Year = userAge.ToString();

            if (userAge < 25)
            {
                quote = quote + 25m;
            }

            if (userAge < 18)
            {
                quote = quote + 100m;
            }

            if (userAge > 100)
            {
                quote = quote + 25m;
            }

            if (carYear < 2000)
            {
                quote = quote + 25m;
            }

            if (carYear > 2015)
            {
                quote = quote + 25m;
            }

            if (carMake.ToLower() == "porsche")
            {
                quote = quote + 25m;
            }

            if (carMake.ToLower() == "porsche" && carModel.ToLower() == "911 carrera")
            {
                quote = quote + 25m;
            }

            for (int i = 0; i < speedingTickets; i++)
            {
                quote = quote + 10m;
            }

            if (radioDui == "yes")
            {
                quote = quote + (50m * .25m);
            }

            if (radioCoverage == "full")
            {
                quote = quote + (50m * .5m);
            }

            using (CarEntities db = new CarEntities())
            {
                var qt = new Quote();
                qt.FirstName = firstName;
                qt.LastName = lastName;
                qt.EmailAddress = emailAddress;
                qt.BirthDate = dateOfBirth;
                qt.InsuranceQuote = quote;

                db.Quotes.Add(qt);
                db.SaveChanges();

                var qts = db.Quotes.ToList();
                return View(qts);
            }
                
            
       }
    }
}