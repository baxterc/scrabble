using System.Collections.Generic;
using System;
using Scrabble;
using System.IO;

namespace Scrabble.Objects
{
  public class ScrabbleWord
  {
    public Dictionary<char,int> letterScore = new Dictionary<char, int>()
    {
      {'a',1},
      {'b',3},
      {'c',3},
      {'d',2},
      {'e',1},
      {'f',4},
      {'g',2},
      {'h',4},
      {'i',1},
      {'j',8},
      {'k',5},
      {'l',1},
      {'m',3},
      {'n',1},
      {'o',1},
      {'p',3},
      {'q',10},
      {'r',1},
      {'s',1},
      {'t',1},
      {'u',1},
      {'v',4},
      {'w',4},
      {'x',8},
      {'y',4},
      {'z',10}
    };
    public int FinalScore = 0;
    public int EnterASingleLetter(char letter)
    {
      var lowerLetter = Char.ToLower(letter);
      if (letterScore.ContainsKey(lowerLetter))
      {
        return letterScore[lowerLetter];
      }
      else
      {
        return 0;
      }
    }
    public int EnterAString(string word)
    {
      char[] characterArray = word.ToCharArray();
      foreach (char c in characterArray)
      {
        char d = Char.ToLower(c);
        if (d == ' ')
        {
          return FinalScore;
        }
        else if (letterScore.ContainsKey(d))
        {
          FinalScore += letterScore[d];
        }
        else
        {
          continue;
        }
      }
      return FinalScore;
    }
  }
}
