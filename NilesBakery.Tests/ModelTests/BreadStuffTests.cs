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
      BreadStuff newBread = new BreadStuff();
      Assert.AreEqual(typeof(BreadStuff), newBread.GetType());
    }
  }
}