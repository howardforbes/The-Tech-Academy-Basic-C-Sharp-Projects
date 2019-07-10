using MVCFinalExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFinalExercise.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            using (var db = new RentalContext())
            {
                var rentalList = db.Rentals.ToList();

                return View(rentalList);
            }

            
        }

        [HttpPost]
        public ActionResult Add(string firstName, string lastName, string movieTitle, string emailAddress, DateTime checkOutDate)
        {
            using (var db = new RentalContext())
            {
                var rental = new Rental();
                rental.FirstName = firstName;
                rental.LastName = lastName;
                rental.MovieTitle = movieTitle;
                rental.Email = emailAddress;
                rental.CheckOutDate = checkOutDate;

                db.Rentals.Add(rental);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Edit(int Id)
        {
            using (var db = new RentalContext())
            {
                var rental = db.Rentals.Find(Id);
                
                return View(rental);

            }

        }

        [HttpPost]
        public ActionResult Edit(int Id, string firstName, string lastName, string movieTitle,
                                    string emailAddress, DateTime checkOutDate)
        {
            using (var db = new RentalContext())
            {

                var rental = db.Rentals.Find(Id);
                rental.FirstName = firstName;
                rental.LastName = lastName;
                rental.MovieTitle = movieTitle;
                rental.Email = emailAddress;
                rental.CheckOutDate = checkOutDate;
                db.SaveChanges();

                return RedirectToAction("Index");

            }
        }

        public ActionResult Delete(int Id)
        {
            using (var db = new RentalContext())
            {
                var rental = db.Rentals.Find(Id);
                db.Rentals.Remove(rental);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
       
    }
}