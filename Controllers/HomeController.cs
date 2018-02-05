using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers

{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/story")]
    public ActionResult Story()
    {
      WordVariables myWords = new WordVariables();
      myWords.SetName(Request.Query["name"]);
      myWords.SetNoun(Request.Query["noun"]);
      myWords.SetVerb(Request.Query["verb"]);

      return View("Story", myWords);
    }
  }
}
