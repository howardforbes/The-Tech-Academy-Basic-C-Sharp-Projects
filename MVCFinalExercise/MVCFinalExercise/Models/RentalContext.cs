using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCFinalExercise.Models
{
    public class RentalContext : DbContext
    {
        public DbSet<Rental> Rentals { get; set; }
    }
}