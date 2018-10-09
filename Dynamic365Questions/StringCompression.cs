using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class StringCompression
    {
        private string StringToCompress = "dooess tthiis wworkkkk with spaces?";

        public string Compress(string compressThis)
        {
            string compressedString = null;
            compressedString += compressThis.ElementAt(0);
                int count = 1;

                for (int i = 1; i < compressThis.Length; ++i)
                {
                    if (compressThis.ElementAt(i) != compressThis.ElementAt(i - 1))
                    {
                    if (count != 1)
                    { compressedString += count.ToString(); }
                            compressedString += compressThis.ElementAt(i);
                            if (count != 1)
                            {
                                    count = 1;
                            }
                    }
                    else
                    {
                            count++;
                    }
                }
                if (count != 1) { compressedString += count.ToString(); }
            return compressedString;
        }

        public void Run()
        {
            Console.WriteLine(Compress(StringToCompress));
        }
    }
}
