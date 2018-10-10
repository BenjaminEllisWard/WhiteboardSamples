using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class CeasarCipher
    {
        // Create a function that takes a string that is prefixed with a number and applies a Ceasar cipher to the string
        // by the amount of the prefix. For example, the string "2test" will become "vguv". Cipher should not affect
        // puncuation and symbols.

        public string Cipher(string message)
        {
            int cipher = 0;
            bool IsNeg = false;

            // check if number is negative and remove '-' character from string
            if (message[0] == 45)
            {
                IsNeg = true;
                message = message.Substring(1);
            }

            foreach (char c in message)
            {
                // if char is a digit, store the digit to cipher
                if (c > 47 && c < 58)
                {
                    cipher *= 10;
                    cipher += (int)char.GetNumericValue(c);
                }

                // if char is not a digit, negate cipher if applicable and remove digits from message
                if (c < 47 || c > 58)
                {
                    if (IsNeg == true) { cipher *= -1; }

                    message = message.Substring(message.IndexOf(c));
                    break;
                }
            }

            // convert cipher to  number of shifts in alphabet
            cipher = ConvertCipher(cipher);

            message = ConvertLetters(message, cipher);

            return message;
        }

        public int ConvertCipher(int cipher)
        {
            bool isNeg = false;

            // check if cipher is negative and make it positive
            if (cipher < 0)
            {
                cipher *= -1;
                isNeg = true;
            }

            // find how many shifts in the alphabet the cipher executes
            while (cipher >= 26)
            {
                cipher -= 26;
            }
            
            // reset the negativity of cipher if applicable
            if (isNeg == true) { cipher *= -1; }

            return cipher;
        }

        public string ConvertLetters(string message, int cipher)
        {
            string cipherMessage = null;

            foreach (char c in message)
            {
                // condition for uppercase letters
                if (c < 91 && c > 64)
                {
                    // condition if shift lands within the uppercase alphabet
                    if (c + cipher < 91 && c + cipher > 64)
                    {
                        cipherMessage += (char)(c + cipher);
                    }
                    // enforce wrap-around when shift takes a letter beyond the ASCII range of uppercase letters
                    else
                    {
                        // If the shift lands before 'A', subtract 26. If beyond 'Z', subtract 26.
                        cipherMessage += c + cipher < 65 ? (char)(c + 26 + cipher) :(char)(c - 26 + cipher);
                    }
                }
                // condition for lowercase letters
                else if (c > 96 && c < 123)
                {
                    // condition if shift lands within the lowercase alphabet
                    if (c + cipher < 123 && c + cipher > 96)
                    {
                        cipherMessage += (char)(c + cipher);
                    }
                    else
                    {
                        // If shift lands before 'a', add 26. If shift lands beyond 'z', subtract 26.
                        cipherMessage += c + cipher < 97 ? (char)(c + 26 + cipher) : (char)(c - 26 + cipher);
                    }
                }
                // condition for non-letter chars
                else
                {
                    cipherMessage += c;
                }
            }
            return cipherMessage;
        }
    }
}
