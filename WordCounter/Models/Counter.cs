namespace Counter.Models
{
  public class Word
  {
    private string _myWord;

    public Word (string myWord)
    {
      _myWord = myWord;
    }

    public string GetWord()
    {
      return _myWord;
    }

    public void SetWord(string newWord)
    {
      _myWord = newWord;
    }

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

  public class Sentence
  {
    private string _mySentence;

    public Sentence (string mySentence)
    {
      _mySentence = mySentence;
    }
  }
}
