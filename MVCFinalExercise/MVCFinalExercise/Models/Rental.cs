using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFinalExercise.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MovieTitle { get; set; }
        public string Email { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}