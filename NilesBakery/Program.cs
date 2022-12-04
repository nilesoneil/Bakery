using System;
using NilesBakery.Models;

namespace StoreFront
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome To Niles' Bakery!");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("MENU");
      Console.WriteLine("");
      Console.WriteLine(" Bread: $5 per loaf");
      Console.WriteLine(" Pastry: $2 per pastry");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("Deal of the Day!");
      Console.WriteLine("");
      Console.WriteLine("Buy two loaves of bread, get one free!");
      Console.WriteLine("Buy three pastries, get the third at half price!");

      int breadPrice = BreadOrder();
      int pastryPrice = PastryOrder();

      if (breadPrice == 0 && pastryPrice == 0)
      {
        Console.WriteLine("Nothing today? Come back soon! ");
      }
      else
      {
        Console.WriteLine($" Your order total is ${breadPrice + pastryPrice}");
      }
    }

    public static int BreadOrder()
    {
      Console.WriteLine("How much bread would you like today?");
      int loafQuantity = UserOrder();
      Bread breadOrder = new Bread(loafQuantity);
      int breadPrice = breadOrder.Price();
      return breadPrice;
    }

    public static int PastryOrder()
    {
      Console.WriteLine("How many pastries would you like today?");
      int pastryQuantity = UserOrder();
      Pastries pastryOrder = new Pastries(pastryQuantity);
      int pastryPrice = pastryOrder.Price();
      return pastryPrice;
    }

    public static int UserOrder()
    {
      string userInput = Console.ReadLine();
      int order;
      bool isParseable = int.TryParse(userInput, out order);

      if (isParseable)
      {
        if(order < 0)
        {
          Console.WriteLine(" Please enter a number:");
          order = UserOrder();
          return order;
        }
        else
        {
          return order;
        }
      }
      else
      {
        Console.WriteLine("Please enter numbers only");
        order = UserOrder();
        return order;
      }
    }
  }
}