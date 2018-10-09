using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class CeasarCipher
    {
        public string Cipher(string message)
        {
            string cipherString = null;
            int cipher = 0;
            bool IsNeg = false;

            if (message[0] == 45)
            {
                IsNeg = true;
                message = message.Substring(1);
            }

            foreach (char c in message)
            {
                if (c > 47 && c < 58)
                {
                    cipher *= 10;
                    cipher += (int)char.GetNumericValue(c);
                }

                if (c < 47 || c > 58)
                {
                    if (IsNeg == true) { cipher *= -1; }

                    message = message.Substring(message.IndexOf(c));
                    break;
                }

            }

            Console.WriteLine(cipher);
            return message;
            foreach (char c in message)
            {
                if (message[message.IndexOf(c)] > 64 && message[message.IndexOf(c)] < 91)
                {
                    cipherString += cipher + message[message.IndexOf(c)];
                }
            }
        }
    }
}
