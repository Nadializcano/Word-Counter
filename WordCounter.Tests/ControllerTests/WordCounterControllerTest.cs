using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
        [TestMethod]
        public void Index()
        {
            WordCounterController controller = new WordCounterController();
            ActionResult indexView = controller.Index();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

      }
    }
