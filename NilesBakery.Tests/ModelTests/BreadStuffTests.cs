using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NilesBakery.Models;

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
      int amount = 3;
      Bread newBread =  new Bread(amount);
      int result = newBread.;
      Assert.AreEqual(amount, result);
    }

    [TestMethod]
    public void GetAmount_ReturnAmount_Int()
    {
      int breadAmount = 3;
      Bread newBread = new Bread(breadAmount);
      int howManyBread = newBread.BreadAmount;
      Assert.AreEqual(breadAmount, howManyBread);
    }


    [TestMethod]
    public void SetDescription_SetDescription_String()  
    {
      string amount = "Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.";
      Bread newBread = new Bread(amount);

      string updatedDescription = "Thanks for your purchase!";
      newBread.Description = updatedDescription;
      string result = newBread.Description;

      Assert.AreEqual(updatedDescription, result);
    }
  }
}