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
  }
}
