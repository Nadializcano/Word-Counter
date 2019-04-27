using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {

    private string _letter;
    private string _sentence;

    public RepeatCounter (string letter, string sentence)
    {
      _letter = letter;
      _sentence = sentence;
    }

    public string GetLetter()
    {
      return _letter;
    }

    public int Counter()
    {
      int count = 0;

      string newLetter = _letter.ToLower();
      string newSentence = _sentence.ToLower();
      string[] sentenceSplit = newSentence.Split();

      foreach (string sentenceLetter in sentenceSplit)
      {
        if (newLetter == sentenceLetter)
        {
          count+=1;
        }
        else
        {
          count+= 0;
        }
      }
      return count;
    }


  }
}
