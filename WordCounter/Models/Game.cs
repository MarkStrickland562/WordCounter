using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  // The Game class contains the sets of words and sentences that the user has entered.

  public class Game
  {
    private static List<Game> _games = new List<Game> {};
    private string _myWord;
    private string _mySentence;
    private int _myCount;
    private int _id;

    public Game(string myWord, string mySentence, int myCount)
    {
      _myWord = myWord;
      _mySentence = mySentence;
      _myCount = myCount;
      _games.Add(this);
      _id = _games.Count;
    }

    public static List<Game> GetAll()
    {
      return _games;
    }

    public static void ClearAll()
    {
      _games.Clear();
    }
  }
}
