using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BestMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        [Required] public DateTime ReleaseTime { get; set; }
        [Required] public DateTime DateAdded { get; set; }
        [Required] public int NumbetInStok { get; set; }
    }
}