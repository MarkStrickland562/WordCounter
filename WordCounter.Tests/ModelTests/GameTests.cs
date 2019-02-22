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
