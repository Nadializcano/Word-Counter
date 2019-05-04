using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;


namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounter")]
   public ActionResult Index()
   {
     return View();
   }

    [HttpGet("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttPost("/wordcounter/show")]
    public ActionResult Show(string inpu1, string sentence)
    {
      WordCounter newCount = new WordCounter(input1, sentence);
      return View(newCount);
    }

  }
}
