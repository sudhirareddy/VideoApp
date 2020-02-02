using System;
using System.Collections.Generic;
using System.Text;

namespace VideoMgtSystem
{/// <summary>
/// Gets the list of movies by Genre available
/// </summary>
/// <param name="TypeOfGenre">Name of Genre</param>
    static class VideoRental
    {
        private static readonly IEnumerable<object> account;
        private static List<Customer> accounts = new List<Customer>();
        public static Customer CreateCustomer(string accountName,
                                     string emailAddress,
                                     TypeOfAccounts AccountType = TypeOfAccounts.Invididual
                                     )
        {//Object Initialization
            var customer = new Customer
            {
                AccountName = accountName,
                AccountType = AccountType,
                EmailAddress = emailAddress
            };
            accounts.Add(customer);
            return customer;

        }
        public static Movie RentalMovie(
            TypeOfGenre GenreType = TypeOfGenre.fiction)
        { //object initialization
            var rental = new Movie { GenreType = GenreType };
            return rental; 
        }
        
    }
}
