using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {

     // [TestMethod]
     // public void GetLetter_ReturnsLetter_String()
     // {
     //   //Arrange
     //   string input1 = "a";
     //   RepeatCounter newInput = new RepeatCounter(input1);
     //
     //   //Act
     //   string result = newInput.GetLetter();
     //   //Assert
     //   Assert.AreEqual(letter, result);
     // }

     [TestMethod]
     public void MatchLetter_LetterEqual_1()
     {
       //Arrange
       string input1 = "a";
       string input2 = "a";

       //Act
       RepeatCounter newInput = new RepeatCounter(input1, input2);
       int result = newInput.Counter();

       //Assert
       Assert.AreEqual(result, 1);
     }

     [TestMethod]
     public void MatchWord_WordEqual_1()
     {
       //Arrange
       string input1 = "cat";
       string input2 = "cat";

       //Act
       RepeatCounter newInput = new RepeatCounter(input1, input2);
       int result = newInput.Counter();

       //Assert
       Assert.AreEqual(result, 1);
     }





  }


  }
