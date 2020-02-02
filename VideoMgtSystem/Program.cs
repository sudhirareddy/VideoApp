using System;

namespace VideoMgtSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Welcome to the Blockbuster Video Rental");

            Console.WriteLine("0:Exit");
            Console.WriteLine("1:Create a account");
            Console.WriteLine("2:CheckOut");
            Console.WriteLine("3:Return");
            Console.WriteLine("4:View my rental");
            Console.WriteLine("5:View all transactions");
            Console.Write("Select an Option:");
            var option=Console.ReadLine();
            switch(option)
            {
                case "0":
                    Console.WriteLine("Thank you for visiting the Blockbuster Video Rental");
                    return;
                case "1":
                    Console.Write("Account Name:");
                    var accountName=Console.ReadLine();
                    Console.Write("Email Address:");
                    var emailAddress = Console.ReadLine();
                    Console.Write("Select an account Type:");
                    var accountTypes = Enum.GetNames(typeof(TypeOfAccounts));
                    for(var i=0;i<accountTypes.Length;i++)
                    {
                        Console.WriteLine($"{i}.{accountTypes[i]}");
                    }
                    var accountType=Enum.Parse<TypeOfAccounts>(Console.ReadLine());
                    var customer = VideoRental.CreateCustomer(accountName, emailAddress, accountType);
                    Console.WriteLine($"AccountNumber:{customer.AccountId}", $"AccountName:{customer.AccountName}", $"emailAddress:{customer.EmailAddress}");
                    

                    break;

                case "2":
                case "3":
                case "4":
                case "5":
                default:
                    Console.WriteLine("Try again");
                    break;


            }

            /*var myRental = VideoMgtSystem.VRental.RentalMovie(TypeOfGenre.kids);

            Console.WriteLine($"Movie:{myRental.MovieName} ,Genre:{myRental.GenreType} ");*/
        }
    }
}
