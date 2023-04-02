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
            if (word.Length == 0)
            {
                return false;
            }
            else
            {
                char[] stringArray = word.ToLower().ToCharArray();
                Array.Reverse(stringArray);
                string backward = new string(stringArray);
                return (word.ToLower() == backward) ? true : false;
            }
            
        }
    }
}
