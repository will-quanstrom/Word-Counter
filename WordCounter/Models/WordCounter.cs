using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word { get; set;}
    public string Sentence { get; set; }
    public RepeatCounter(string word, string sentence)
    {
      Word = word;
      Sentence = sentence;
    }

    public bool IsWord()
    {
      string abc = "abcdefghijklmnopqrstuvwxyz";
      string lowercase = Word.ToLower();

      for (int i = 0; i < Word.Length; i++)
      {
        if ( !abc.Contains(lowercase[i]) )
        {
          return false;
        }
      }
      return true;
    }

    public bool IsSentence()
    {
      if (this.IsUpperCased())
      {
        return true;
      }
      else{
        return false;
      }
    }

    public bool IsUpperCased()
    {
      string[] sentenceArr = Sentence.Split(" ");
      string firstWord = sentenceArr[0];
      string firstUpper = firstWord.ToUpper();

      if ( firstWord[0] == firstUpper[0])
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool IsPuncuated()
    {
      return false;
    }
  }
}