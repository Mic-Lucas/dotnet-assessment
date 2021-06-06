using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("value cannot be null or empty");

            //set collection of vowels
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            int vowelCount = -0;

            //loop through characters in value to see if it exists in the vowel array
            foreach (var character in value.ToLower())
            {
                if (Array.IndexOf(vowels, character) > -1)
                    vowelCount++;
            }

            return vowelCount;
        }
    }
}
