using System;
using System.Text;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            //validate paramaters
            if (string.IsNullOrEmpty(word1))
                throw new ArgumentException("word1 cannot be null");

            if (string.IsNullOrEmpty(word2))
                throw new ArgumentException("word2 cannot be null");

            //Remove punctuation and spaces
            word1 = CleanWord(word1);
            word2 = CleanWord(word2);

            // can't be anagram if words are of different length
            if (word1.Length != word2.Length)
                return false;

            // convert to sorted arrays
            var charArray1 = word1.ToLower().ToCharArray();
            var charArray2 = word2.ToLower().ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);

            //compare sorted arrays 
            for (int index = 0; index < charArray1.Length; index++)
                if (charArray1[index] != charArray2[index])
                    return false; //no match

            //all chars match
            return true;
        }

        //Remove punctuation from word
        private string CleanWord(string word)
        {
            var sb = new StringBuilder();

            foreach (char character in word)
            {
                if (!char.IsPunctuation(character) && character != ' ')
                    sb.Append(character);
            }

            return sb.ToString();
        }
    }
}
