using System;

namespace Counter.Models
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

  // RepeatCounter class has one method for counting the occurrences of a user-entered word in a user-entered sentence.

  public class RepeatCounter
  {

    // Method for counting the occurrences of the word. Other words in the sentence cannot contain the word in order for the word to count.
    public static int GetCount(string myWord, string mySentence)
    {
      int _counter = 0;

      if (mySentence.Contains(myWord))
      {
        string[] _mySentenceArray = mySentence.ToUpper().Split(new Char [] {' ', ',', ';', ':'});

        foreach (string str in _mySentenceArray)
        {
          Console.WriteLine(str);
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
