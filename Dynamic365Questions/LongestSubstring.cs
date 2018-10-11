using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class LongestSubstring
    {
        // Given a string, find the length of the longest substring without repeating a character.
        // Ex: "abcabcbb" => "abc", "bbbbb" => "b", "pwwkew" => "wke"

        // Makes an array of substrings of a given string. Each array element corresponds to a substring whose beginning
        // index increments across input string's length with an ending index that terminates with the inputs last unique
        // character within the substring.
        public string[] FindSubs(string message)
        {
            // array holds substrings
            string[] subMessages = new string[message.Length];

            for (int i = 0; i < message.Length; ++i)
            {
                string subMessage = null;
                // add first char of substring
                subMessage += message.ElementAt(i);

                for (int j = i + 1; j < message.Length; ++j)
                {
                    if (UniqueChar(message.Substring(i, j + 1 - i)) == true)
                    {
                        // add next char to subMessage if char is unique
                        subMessage += message.ElementAt(j);
                    }

                    // terminate substring if the char is a repetition of a previous char
                    if (UniqueChar(message.Substring(i, j + 1 - i)) == false) { break; }
                }

                // assign array element to complete substring
                subMessages[i] = subMessage;
            }

            return subMessages;
        }

        // find longest string in an array of strings
        public string FindMaxString(string[] subs)
        {
            // initialize with first element
            string max = subs[0];

            foreach (string sub in subs)
            {
                // assign max to element if element.Length is greater than max.Length
                if (sub.Length > max.Length)
                {
                    max = sub;
                }
            }

            return max;
        }

        // checks if last char in a string is unique
        public bool UniqueChar(string message)
        {
            for (int i = 0; i < message.Length - 1; ++i)
            {
                if (message.ElementAt(message.Length - 1) == message.ElementAt(i))
                {
                    return false;
                }
            }

            return true;
        }

        public void Run(string message)
        {
            Console.WriteLine($"The longest substring with no repeating characters in {message} is " +
                $"{FindMaxString(FindSubs(message)).Length} characters long.");
            Console.WriteLine($"Longest substring: '{FindMaxString(FindSubs(message))}'"); 
        }
    }
}
