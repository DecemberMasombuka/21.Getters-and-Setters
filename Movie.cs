using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Getters_and_Setters
{
    internal class Movie
    {
        public string title;
        public string director;
        public string rating;


        //Constructor
        public Movie(string title, string director, string arating)
        {
            this.title = title;
            this.director = director;
            Rating = arating;
        }

        public String Rating
        {
            get { return rating; } //Getter
            set //Setter
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value;

                }else
                {
                    rating = "NR";
                }
            }
        }

    }
}
