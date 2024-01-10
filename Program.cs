using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Getters_and_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Danger", "Mark Teryy", "PG");
            Movie movie2 = new Movie("Sweet Love", "Bobby Gill", " ");

            Console.WriteLine(movie1.Rating);
            Console.WriteLine(movie2.Rating);

            Console.Read();
        }
    }
}
