using System;

namespace VideoMgtSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var myRental = VideoMgtSystem.VRental.RentalMovie(TypeOfGenre.kids);

            Console.WriteLine($"Movie:{myRental.MovieName} ,Genre:{myRental.GenreType} ");
        }
    }
}
