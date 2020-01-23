using System;
using System.Collections.Generic;
using System.Text;

namespace VideoMgtSystem
{/// <summary>
/// Gets the list of movies by Genre available
/// </summary>
/// <param name="TypeOfGenre">Name of Genre</param>
    static class VRental
    {
        public static Movie RentalMovie(
            TypeOfGenre GenreType = TypeOfGenre.fiction)
        { //object initialization
            var rental = new Movie { GenreType = GenreType };
            return rental;
        }
    }
}
