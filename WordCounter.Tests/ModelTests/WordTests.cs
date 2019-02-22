using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    // Verify that an instance of Word can be created.
    public void WordConstructor_CreatesInstanceOfWord()
    {
      //Arrange
      string myWord = "test";
      Word newWord = new Word(myWord);

      //Act
      Type myWordType = typeof(Word);
      Type newWordType = newWord.GetType();

      //Assert
      Assert.AreEqual(myWordType, newWordType);
    }

    [TestMethod]
    // Verify that the Word getter method returns the value of the word.
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
    // Verify that the Word setter method can update the value of the word.
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
    // Verify that a word was not actually entered.
    public void ValidateWord_CheckExistence_False()
    {
      //Arrange
      string myWord = "";
      Word newWord = new Word(myWord);

      //Act
      bool isValid = newWord.ValidateWord(myWord);

      //Assert
      Assert.AreEqual(false, isValid);
    }

    [TestMethod]
    // Verify that a word was actually entered.
    public void ValidateWord_CheckExistence_True()
    {
      //Arrange
      string myWord = "test";
      Word newWord = new Word(myWord);

      //Act
      bool isValid = newWord.ValidateWord(myWord);

      //Assert
      Assert.AreEqual(true, isValid);
    }

    [TestMethod]
    // Verify that just one word was entered.
    public void ValidateWord_CheckOneWord_false()
    {
      //Arrange
      string myWord = "two words";
      Word newWord = new Word(myWord);

      //Act
      bool isValid = newWord.ValidateWord(myWord);
      //Assert
      Assert.AreEqual(false, isValid);
    }

    [TestMethod]
    // Verify that the word contains only alphabetic characters and no spaces.
    public void ValidateWord_CheckAlphaOnly_false()
    {
      //Arrange
      string myWord = "1 word!";
      Word newWord = new Word(myWord);

      //Act
      bool isValid = newWord.ValidateWord(myWord);
      //Assert
      Assert.AreEqual(false, isValid);
    }
  }
}
