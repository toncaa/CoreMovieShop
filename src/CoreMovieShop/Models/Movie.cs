using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMovieShop.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public float Rating { get; set; }
        public string Plot { get; set; }
        public string Author { get; set; }
        public string Poster { get; set; }
        public List<string> Actors { get; set; }
        public DateTimeOffset Released { get; set; }

    }
}
