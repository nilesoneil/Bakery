using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NilesBakery.Models;

namespace NilesBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastriesConstructor_CreatesInstanceOfPastries_PastriesObject()
    {
      Pastries newPastry = new Pastries(3);
      Assert.AreEqual(typeof(Pastries), newPastry.GetType());
    }

    [TestMethod]
    public void PastriesConstructor_CreatesInstanceOfPastriesWithPastryCount_Int()
    {
      Pastries newPastry = new Pastries(3);
      Assert.AreEqual(3, newPastry.PastryAmount);
    }

    [TestMethod]
    public void Price_ReturnsCostOfOrder_Int()
    {
      Pastries newPastry = new Pastries(7);
      Assert.AreEqual(12, newPastry.Price());
    }

    [TestMethod]
    public void Price_ReturnsCostWithDiscount_Int()
    {
      Pastries newPastry = new Pastries(3);
      Assert.AreEqual(5, newPastry.Price());
    }
  }
}