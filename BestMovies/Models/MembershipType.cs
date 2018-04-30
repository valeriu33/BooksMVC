using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestMovies.Models
{
    public class MembershipType
    {
        public int Id { get; set; }

        public string Duration { get; set; }

        public decimal SignUpFree { get; set; }

        public int DiscountRate { get; set; }
    }
}