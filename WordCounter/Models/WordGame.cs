using System;
using System.Collections.Generic;

namespace WordCounter.Models


{
   public class RepeatCounter
   {

     private string _input1;
     private string _sentence;

     public RepeatCounter (string input1, string sentence)
     {
       _input1 = input1;
       _sentence = sentence;
     }

     public string GetLetter()
     {
       return _input1;
     }

     public string GetSentence()
     {
       return _sentence;
     }



      public int Counter()
      {
        int count = 0;

        string newLetter = _input1.ToLower();
        string newSentence = _sentence.ToLower();
        string[] sentenceSplit = newSentence.Split();

        foreach (string sentenceInput1 in sentenceSplit)
        {
          if (newLetter == sentenceInput1)
          {
            count+=1;
          }

        }
        return count;
      }

}


}
