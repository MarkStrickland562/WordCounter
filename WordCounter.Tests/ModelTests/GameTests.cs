using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class GameTest : IDisposable
  {
    public void Dispose()
    {
      Game.ClearAll();
    }

    [TestMethod]
    // Verify that the Word getter method returns the value of the word.
    public void GetWord_ReturnsWord_String()
    {
      //Arrange
      string myWord = "test1";
      string mySentence = "A sentence for test1";
      int myCount = 1;
      Game newGame = new Game(myWord, mySentence, myCount);

      //Act
      string result = newGame.GetWord();

      //Assert
      Assert.AreEqual(myWord, result);
    }

    [TestMethod]
    // Verify that the Sentence getter method returns the value of the sentence.
    public void GetSentence_ReturnsSentence_String()
    {
      //Arrange
      string myWord = "test1";
      string mySentence = "A sentence for test1";
      int myCount = 1;
      Game newGame = new Game(myWord, mySentence, myCount);

      //Act
      string result = newGame.GetSentence();

      //Assert
      Assert.AreEqual(mySentence, result);
    }

    [TestMethod]
    // Verify that the Count getter method returns the value of the count.
    public void GetCount_ReturnsCount_Int()
    {
      //Arrange
      string myWord = "test1";
      string mySentence = "A sentence for test1";
      int myCount = 1;
      Game newGame = new Game(myWord, mySentence, myCount);

      //Act
      int result = newGame.GetCount();

      //Assert
      Assert.AreEqual(myCount, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllGames_GameList()
    {
      //Arrange
      string word1 = "test1";
      string word2 = "test2";
      string sentence1 = "A sentence for test1" ;
      string sentence2 = "A sentence for test2";
      int count1 = 1;
      int count2 = 2;
      Game newGame1 = new Game(word1, sentence1, count1);
      Game newGame2 = new Game(word2, sentence2, count2);
      List<Game> newList = new List<Game> { newGame1, newGame2 };

      //Act
      List<Game> result = Game.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
