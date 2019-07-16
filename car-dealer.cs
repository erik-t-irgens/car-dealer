using System;
using System.Collections.Generic;

class Car
{
  public string makeModel;
  public int price;
  public int miles;

  public bool WorthBuying(int maxPrice)
  {
    return (price < maxPrice);
  }
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car();
    volkswagen.makeModel = "1974 Volkswagen Thing";
    volkswagen.price = 1100;
    volkswagen.miles = 368792;

    Car yugo = new Car();
    yugo.makeModel = "1980 Yugo Koral";
    yugo.price = 700;
    yugo.miles = 56000;

    Car ford = new Car();
    ford.makeModel = "1988 Ford Country Squire";
    ford.price = 1400;
    ford.miles = 239001;

    Car amc = new Car();
    amc.makeModel = "1976 AMC Pacer";
    amc.price = 400;
    amc.miles = 198000;

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.makeModel);
    }
  }
}