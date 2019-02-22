using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    // Verify that the actual count of a word in a sentence matches the expected count.
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
