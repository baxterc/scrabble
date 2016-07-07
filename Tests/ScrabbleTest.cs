using Xunit;
using System.Collections.Generic;
using Scrabble.Objects;

namespace Scrabble
{
  public class ScrabbleTest
  {
    [Fact]
    public void EnterASingleLetter_ReturnPoint_1()
    {
      ScrabbleWord word = new ScrabbleWord();
      Assert.Equal(1, word.EnterASingleLetter('A'));
    }
    [Fact]
    public void EnterAString_ReturnPoint_5()
    {
      ScrabbleWord word = new ScrabbleWord();
      Assert.Equal(5, word.EnterAString("Hi"));
    }
    [Fact]
    public void EnterMultipleWords_Return_5()
    {
      ScrabbleWord word = new ScrabbleWord();
      Assert.Equal(5, word.EnterAString("Hi friend"));
    }
    [Fact]
    public void EnterNonStandardChar_Return_5()
    {
      ScrabbleWord word = new ScrabbleWord();
      Assert.Equal(5, word.EnterAString(".Hi"));
    }
  }
}
