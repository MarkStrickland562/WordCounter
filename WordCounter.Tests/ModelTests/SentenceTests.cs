using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class SentenceTest
  {
    [TestMethod]
    // Verify that an instance of a Sentence can be created.
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
    // Verify that the Sentence getter method returns the value of the sentence.
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
    // Verify that the Sentence setter method can update the value of the sentence.
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
    // Verify that a sentence was not actually entered.
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
    // Verify that a sentence was actually entered.
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
    // Verify that the sentence only contains alphabetic characters.
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
  }
}
