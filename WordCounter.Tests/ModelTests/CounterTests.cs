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
      Word newWord = new Word("test");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }
  }
}
