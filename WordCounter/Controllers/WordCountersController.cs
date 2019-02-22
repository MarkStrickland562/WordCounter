using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCountersController : Controller
  {
    [HttpGet("/wordcounters/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}
