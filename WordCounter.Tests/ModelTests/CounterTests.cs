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

    [TestMethod]
    public void SetWord_SetWord_String()
    {
      //Arrange
      string myWord = "test";
      Word newWord = new Word(myWord);

      //Act
      string updatedWord = "newtest";
      newWord.SetWord(updatedWord);
      string result = newWord.GetWord();

      //Assert
      Assert.AreEqual(updatedWord, result);
    }

    [TestMethod]
    public void ValidateWord_CheckExistence_False()
    {
      //Arrange
      string myWord = "";
      Word newWord = new Word(myWord);

      //Act

      //Assert
      Assert.AreEqual(false, newWord.ValidateWord(myWord));
    }
  }
}
