using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLover.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Director { get; set; }

        public string Cover { get; set; }
        public string Genre { get;  set; }
        public float Score { get; set; }
        public Movie()
        {

        }
    }
}

  
