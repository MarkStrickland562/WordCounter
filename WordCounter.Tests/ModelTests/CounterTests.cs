using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter.Models;

namespace Counter.Tests
{
  [TestClass]
  public class CounterTest
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord()
    {
      //Arrange
      string myWord = "test";
      Word newWord = new Word(myWord);

      //Act

      //Assert
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      //Arrange
      string myWord = "test";
      Word newWord = new Word(myWord);

      //Act
      string result = newWord.GetWord();

      //Assert
      Assert.AreEqual(myWord, result);
    }
  }
}
