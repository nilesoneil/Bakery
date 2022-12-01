using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NilesBakery.Models;
using System;

namespace NilesBakery.Tests
{
  [TestClass]
  public class NilesBakeryTests
  {
    [TestMethod]
    public void BakeryConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("test");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.";
      Bread newBread =  new Bread(description);
      string result = newBread.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void UserPrompt_UserInput_Int()
    {
      string userInput;
      Console.Write("How much bread would you like?");
      userInput = Console.ReadLine();
      Console.WriteLine("'{0}' bread coming right up!", userInput);
      Bread newBread = new Bread();
    }


    [TestMethod]
    public void SetDescription_SetDescription_String()  
    {
      string description = "Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.";
      Bread newBread = new Bread(description);

      string updatedDescription = "Thanks for your purchase!";
      newBread.Description = updatedDescription;
      string result = newBread.Description;

      Assert.AreEqual(updatedDescription, result);
    }
  }
}