using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {

    [TestMethod]
    public void GetLetter_ReturnsLetter_String()
    {
      //Arrange
      string letter = "a";
      RepeatCounter newWord = new RepeatCounter(letter);

      //Act
      string result = newWord.GetLetter();
      Assert.AreEqual(letter, result);
    }


  }
}
