using Microsoft.AspNetCore.Mvc;
using WordCount.Models;
using System.Collections.Generic;

namespace WordCount.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }
				[HttpPost("/results")]
        public ActionResult Results()
        {
					RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["input-string"], Request.Form["input-keyword"]);
					newRepeatCounter.CreateSearchedStringList();
					newRepeatCounter.CalculateWordTotal();
          return View(newRepeatCounter);
        }
    }
}
