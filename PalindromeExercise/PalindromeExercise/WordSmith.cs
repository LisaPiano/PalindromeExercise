using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string word)
        {
            if (word == null || word.Length == 0)
            {
                return false;
            }

            //string reverse = "";
            //for (int i = word.Length -1; i >= 0; i--)
            //{
            //    reverse += word[i];
            //}

            //if (reverse == word)
            //{
            //    return true;
            //}
            //else
            //{ 
            //    return false; 
            //}

            //refactored below

            string lower = word.ToLower();

            var reversedWord = lower.Reverse();

            return lower.SequenceEqual(reversedWord);

           


        }
    }
}
