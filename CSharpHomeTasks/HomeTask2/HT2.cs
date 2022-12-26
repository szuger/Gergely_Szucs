/*
Write a function named first_non_repeating_letter that takes a string input, and returns the first character that is not repeated anywhere in the string.
For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.
As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter. For example, the input 'sTreSS' should return 'T'.
If a string contains all repeating characters, it should return an empty string ("") or None -- see sample tests.
*/

using NUnit.Framework;
using System.ComponentModel.Design;

namespace CSharpHomeTask2
{
    public class HT2
    {
        [Test]
        public void Test1_Uppercase()
        {
            string word = "STress";
            string expectedResult = "T";
            string result = First_non_repeating_letter(word);

            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test2_AllRepeting()
        {
            string word = "aabbvveeehh";
            string expectedResult = "";
            string result = First_non_repeating_letter(word);

            Assert.AreEqual(expectedResult, result);
        }
        public static string First_non_repeating_letter(string s)
        {
            string solution = "";
            string Lowstring = s.ToLower();
            Console.WriteLine(s);

            for (int i = 0; i < s.Length; i++)
            {
                if ((Lowstring.IndexOf(Lowstring[i], Lowstring.IndexOf(Lowstring[i]) + 1) == -1))
                {
                    solution = Char.ToString(s[i]);

                    break;
                }
            }
            return solution;
        }

    }
}