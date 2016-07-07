using System;
using System.Collections.Generic;
using Nancy;
using Scrabble.Objects;

namespace Scrabble
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        ScrabbleWord word = new ScrabbleWord();
        int score = word.EnterAString(Request.Form["user-input"]);
        return View["index.cshtml", score];
      };
    }
  }
}
