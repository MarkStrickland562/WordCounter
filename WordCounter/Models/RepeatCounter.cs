using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {

    // Method for counting the occurrences of the word. Other words in the sentence cannot contain the word in order for the word to count.
    public static int GetCount(string myWord, string mySentence)
    {
      int _counter = 0;

      if (mySentence.ToUpper().Contains(myWord.ToUpper()))
      {
        string[] _mySentenceArray = mySentence.ToUpper().Split(new Char [] {' ', ',', ';', ':'});

        foreach (string str in _mySentenceArray)
        {
          if (str == myWord.ToUpper())
          {
            _counter += 1;
          }
        }
      }
      return _counter;
    }
  }
}
