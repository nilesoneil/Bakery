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
      Breadstuff newBread = new Breadstuff()
      Assert.AreEqual(typeof(Breadstuff), newBread.GetType());
    }
  }
}