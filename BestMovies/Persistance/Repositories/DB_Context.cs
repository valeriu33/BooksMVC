using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BestMovies.Models;


namespace BestMovies.Persistance.Repositories
{
    public class DB_Context : DbContext
    {
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<MembershipType> MembershipTypes { get; set; }
    }
}