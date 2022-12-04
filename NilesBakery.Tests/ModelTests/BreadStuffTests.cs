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
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BakeryConstructor_CreatesInstanceOfBreadWithBreadCount_Int()
    {
      Bread newBread =  new Bread(3);
      Assert.AreEqual(3, newBread.BreadAmount);
    }

    [TestMethod]
    public void Price_ReturnsPriceOfOrder_Int()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(5, newBread.Price());
    }
    
  }
}