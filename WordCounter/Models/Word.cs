using System;

namespace WordCounter.Models
{
  // The Word class contains the constructor and methods to store and process a user-entered word.

  public class Word
  {
    private string _myWord;

    // Constructor for creating an instance of the Word class.

    public Word (string myWord)
    {
      _myWord = myWord;
    }

    // Getter method for the Word class.

    public string GetWord()
    {
      return _myWord;
    }

    // Setter method for the Word class.

    public void SetWord(string newWord)
    {
      _myWord = newWord;
    }

    // Method for validating a user-entered word. A valid user-entered word:
    //
    // 1) Is not blank.
    // 2) Contains only alphabetic characters.
    // 3) Does not contain any spaces.

    public bool ValidateWord(string myWord)
    {
      char[] _myWordArray = myWord.ToUpper().ToCharArray();
      bool _alpha = true;

      foreach (char ch in _myWordArray)
      {
        if (ch < 'A' || ch > 'Z')
        {
          _alpha = false;
        }
      }

      if (myWord == "")
      {
        return false;
      }
      else if (myWord.Contains(" "))
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
