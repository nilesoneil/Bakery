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
      Bread newBread = new Bread("test");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Crispy crunchy bread.";
      Bread newBread =  new Bread(description);
      string result = newBread.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()  
    {
      string description = "Crispy crunchy bread.";
      Bread newBread = new Bread(description);

      string updatedDescription = "Do the dishes";
      newBread.Description = updatedDescription;
      string result = newBread.Description;

      Assert.AreEqual(updatedDescription, result);
    }
  }
}