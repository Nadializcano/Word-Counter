using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTests
    {
      [TestMethod]
      public void GetInput_ReturnsInput_true()
      {
        RepeatCounter newInput = new RepeatCounter("a","a");

        string input1 = newInput.GetLetter();
        string sentence = newInput.GetSentence();

        Assert.AreEqual("a", input1);
        Assert.AreEqual("a", sentence);
      }

      [TestMethod]
      public void MatchLetter_LetterEqual_1()
      {
        string input1 = "a";
        string sentence = "a";

        RepeatCounter newInput = new RepeatCounter(input1, sentence);
        int result = newInput.Counter();

        Assert.AreEqual(result, 1);
      }

      [TestMethod]
      public void MatchWord_WordEqual_1()
      {
        string input1 = "cat";
        string sentence = "cat";

        RepeatCounter newInput = new RepeatCounter(input1, sentence);
        int result = newInput.Counter();

        Assert.AreEqual(result, 1);
      }

      [TestMethod]
      public void CountMatch_NumberOfMatch_2()
      {
        string input1 = "cat";
        string sentence = "The cat is grey. She is my cat";

        RepeatCounter newInput = new RepeatCounter(input1, sentence);
        int result = newInput.Counter();

        Assert.AreEqual(2, result);
      }
   }
}
