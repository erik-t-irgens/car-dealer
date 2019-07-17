using System;
using System.Collections.Generic;


// Car class that defines the constructor
namespace Dealership.Models
{
    class Car
    {
        private string _MakeModel;
        private int _Price;
        private int _Miles;
        // Constructor logic that is a function, and takes the information from constructions later and adds those values to the pre-determined values above.
        public Car(string makeModel, int price, int miles)
        {
            _MakeModel = makeModel;
            _Price = price;
            _Miles = miles;
        }


        // Getters and setters for private variables.
        public void SetPrice(int newPrice)
        {
            _Price = newPrice;
        }


        public string GetMakeModel()
        {
            return _MakeModel;
        }
        public int GetPrice()
        {
            return _Price;
        }
        public int GetMiles()
        {
            return _Miles;
        }

        // Static method that is car agnostic, but works for the whole dealership
        public static string MakeSound(string sound)
        {
            return "Our cars sound like " + sound;
        }

        // Function to determine if Price of car is less than maxPrice (True/false)

        public bool WorthBuying(int maxPrice)
        {
            return (_Price < maxPrice);
        }
        public bool WorthDriving(int maxMiles)
        {
            return (_Miles < maxMiles);
        }
    }
}


