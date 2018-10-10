using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class StringCompression
    {
        // Write a function that compresses a string so that repeated characters are written once with the number
        // of repetitions following. For example, "assddd" would become "as2d3".

        public string Compress(string compressThis)
        {
            string compressedString = null;

            // add first char to compressedString
            compressedString += compressThis.ElementAt(0);

            // variable tracks the number of consecutive repetitions of a char
            int count = 1;

            // begins at 1 since first char is already added
            for (int i = 1; i < compressThis.Length; ++i)
            {
                // condition for char that is not a repetition of previous char
                if (compressThis.ElementAt(i) != compressThis.ElementAt(i - 1))
                {
                    // If previous char was repeated, add its count to compressedString
                    if (count != 1)
                    { compressedString += count.ToString(); }

                    // Add next char
                    compressedString += compressThis.ElementAt(i);

                    // reset count
                    if (count != 1)
                    {
                            count = 1;
                    }
                }
                // increment count if char is a repetition of previous char
                else
                {
                        count++;
                }
            }

            // add count of final char to compressedString if final char is a repetition
            if (count != 1) { compressedString += count.ToString(); }

            return compressedString;
        }

        public void Run(string message)
        {
            Console.WriteLine(Compress(message));
        }
    }
}
