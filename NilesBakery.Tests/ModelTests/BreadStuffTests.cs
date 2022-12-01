using Microsoft.VisualStudio.TestTools.UnitTesting;
using NilesBakery.Models;

namespace NilesBakery.Tests
{
  [TestClass]
  public class NilesBakeryTests
  {
    [TestMethod]
    public void BakeryConstructor_CreatesInstanceOfBread_Bread()
    {
      BreadStuff newBread = new BreadStuff("test");
      Assert.AreEqual(typeof(BreadStuff), newBread.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Crispy crunchy bread.";
      BreadStuff newBread =  new BreadStuff(description);
      string result = newBread.Description;
      Assert.AreEqual(description, result);
    }
  }
}