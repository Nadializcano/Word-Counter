using System:
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
    }

    public string GetLetter()
    {
      return _letter;
    }

    public int Counter()
    {
      string newLetter = _letter.ToLower();
      string newSentence = _sentece.ToLower();
      string[] sentenceSplit = newSentence.Split();

      foreach (string sentence in sentenceSplit)
      {
        if (newLetter == sentence)
        {
          count+=1;
        }
      }
      return count;
    }


  }
}
