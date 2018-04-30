using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestMovies.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsSubscribetToNewsLetter { get; set; }
        public DateTime? BirthDate { get; set; }

        public int MembershipTypeId { get; set; }
        public MembershipType Membership { get; set; }
    }
}