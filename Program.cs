using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
    // What calls the logic in the backend (above, I assume) and interacts with user.
    public class Program
    {
        public static void Main()
        {
            //   Construction of cars. 
            Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
            Car yugo = new Car("1980 Yugo Koral", 700, 56000);
            Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
            Car amc = new Car("1976 AMC Pacer", 400, 198000);
            // List containing all instances of the Car objects (that have been defined)
            List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

            // test for the setter
            yugo.SetPrice(300);


            Console.WriteLine("Enter maximum price: ");
            string stringMaxPrice = Console.ReadLine();
            int maxPrice = int.Parse(stringMaxPrice);

            Console.WriteLine("Enter maximum mileage: ");
            string stringMaxMiles = Console.ReadLine();
            int maxMiles = int.Parse(stringMaxMiles);

            // Empty list to be filled with search criteria.
            List<Car> CarsMatchingSearch = new List<Car>(0);

            // foreach loop that adds cars that meet price criteria to above list



            foreach (Car automobile in Cars)
            {
                if (automobile.WorthBuying(maxPrice) && automobile.WorthDriving(maxMiles))
                {
                    CarsMatchingSearch.Add(automobile);
                }
                else
                {
                    Console.WriteLine("No cars are available for purchase under your search critera.");
                    Console.WriteLine("Would you like to make another query?");
                    string answer = Console.ReadLine();
                    if (answer == "yes" || answer == "Yes" || answer == "YES")
                    {
                        Main();

                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");
                        return;
                    }
                }

            }
            // foreach that displays the search critera above to user.
            foreach (Car automobile in CarsMatchingSearch)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine(automobile.GetMakeModel());
                Console.WriteLine(automobile.GetMiles() + " miles");
                Console.WriteLine("$" + automobile.GetPrice());
            }
        }
    }
}