using System;

namespace WordCounter.Models
{
  // The Sentence class contains the constructor and methods to store and process a user-entered sentence.

  public class Sentence
  {
    private string _mySentence;

    public Sentence (string mySentence)
    {
      _mySentence = mySentence;
    }

    // Getter method for the Sentence class.

    public string GetSentence()
    {
      return _mySentence;
    }

    // Setter method for the Sentence class.

    public void SetSentence(string newSentence)
    {
      _mySentence = newSentence;
    }

    // Method for validating a user-entered sentence. A valid user-entered sentence:
    //
    // 1) Is not blank.
    // 2) Contains only alphabetic characters.

    public bool ValidateSentence(string mySentence)
    {
      char[] _mySentenceArray = mySentence.ToUpper().ToCharArray();
      bool _alpha = true;

      foreach (char ch in _mySentenceArray)
      {
        if (ch != ' ' && (ch < 'A' || ch > 'Z'))
        {
          _alpha = false;
        }
      }

      if (mySentence == "")
      {
        return false;
      }
      else if (!_alpha)
      {
        return false;
      }
      return true;
    }
  }
}
