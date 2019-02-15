using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
      Type myWordType = typeof(Word);
      Type newWordType = newWord.GetType();

      //Assert
      Assert.AreEqual(myWordType, newWordType);
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
      bool isValid = newWord.ValidateWord(myWord);

      //Assert
      Assert.AreEqual(false, isValid);
    }

    [TestMethod]
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

    [TestMethod]
    public void SentenceConstructor_CreatesInstanceOfSentence()
    {
      //Arrange
      string mySentence = "I am a student";
      Sentence newSentence = new Sentence(mySentence);

      //Act
      Type mySentenceType = typeof(Sentence);
      Type newSentenceType = newSentence.GetType();

      //Assert
      Assert.AreEqual(mySentenceType, newSentenceType);
    }

    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      //Arrange
      string mySentence = "I am a student";
      Sentence newSentence = new Sentence(mySentence);

      //Act
      string result = newSentence.GetSentence();

      //Assert
      Assert.AreEqual(mySentence, result);
    }

    [TestMethod]
    public void SetSentence_SetSentence_String()
    {
      //Arrange
      string mySentence = "I am a student";
      Sentence newSentence = new Sentence(mySentence);

      //Act
      string updatedSentence = "I am a good student";
      newSentence.SetSentence(updatedSentence);
      string result = newSentence.GetSentence();

      //Assert
      Assert.AreEqual(updatedSentence, result);
    }

    [TestMethod]
    public void ValidateSentence_CheckExistence_False()
    {
      //Arrange
      string mySentence = "";
      Sentence newSentence = new Sentence(mySentence);

      //Act
      bool isValid = newSentence.ValidateSentence(mySentence);

      //Assert
      Assert.AreEqual(false, isValid);
    }

    [TestMethod]
    public void ValidateSentence_CheckExistence_True()
    {
      //Arrange
      string mySentence = "I am a student";
      Sentence newSentence = new Sentence(mySentence);

      //Act
      bool isValid = newSentence.ValidateSentence(mySentence);

      //Assert
      Assert.AreEqual(true, isValid);
    }

    [TestMethod]
    public void ValidateSentence_CheckAlphaOnly_false()
    {
      //Arrange
      string mySentence = "1 @am a stud3nt!";
      Sentence newSentence = new Sentence(mySentence);

      //Act
      bool isValid = newSentence.ValidateSentence(mySentence);

      //Assert
      Assert.AreEqual(false, isValid);
    }

    [TestMethod]
    public void RepeatCounter_GetCount_Int()
    {
      //Arrange
      string myWord = "a";
      string mySentence = "I am a student";
      Word newWord = new Word(myWord);
      Sentence newSentence = new Sentence(mySentence);
      string stringWord = newWord.GetWord();
      string stringSentence = newSentence.GetSentence();

      //Act
      int myCount = RepeatCounter.GetCount(stringWord, stringSentence);

      //Assert
      Assert.AreEqual(1, myCount);
    }
  }
}
