using System;
using System.Collections.Generic;
using System.Text;

namespace Z_Tata_GC_Lab_10
{
    public class Movie
    {
        private string movieTitle;
        public string MovieTitle
        {
            get { return movieTitle; }
            set { movieTitle = value; }
        }

        
        private MovieCategory movieCategory;
        public MovieCategory MovieCategory
        {
            get { return movieCategory; }
            set { movieCategory = value; }
        }

        public Movie (string movieTitle, MovieCategory movieCategory)
        {
            MovieTitle = movieTitle;
            MovieCategory = movieCategory;
        }

    }
}
