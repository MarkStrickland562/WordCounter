using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounters")]
    public ActionResult Index()
    {
      List<Game> allGames = Game.GetAll();
      return View(allGames);
    }

    [HttpGet("/wordcounters/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/wordcounters")]
    public ActionResult Create(string myWord, string mySentence)
    {
      Word newWord = new Word(myWord);
      Sentence newSentence = new Sentence(mySentence);

      if (!(string.IsNullOrEmpty(newWord.GetWord())) && !(string.IsNullOrEmpty(newSentence.GetSentence())))
      {
        if (newWord.ValidateWord(newWord.GetWord()) && newSentence.ValidateSentence(newSentence.GetSentence()))
        {
          int newCount = RepeatCounter.GetCount(newWord.GetWord(), newSentence.GetSentence());
          Game newGame = new Game(newWord.GetWord(), newSentence.GetSentence(), newCount);

          return View("Show", newGame);
        }
        else
        {
          return View("New");
        }
      }
      else
      {
        return View("New");
      }
    }
  }
}
