using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringCompression compression = new StringCompression();
            //compression.Run("Compresss thiiiiis message");

            //DigitalRoot digitalRoot = new DigitalRoot();
            //digitalRoot.Run(109);

            PalindromeGenerator pal = new PalindromeGenerator();
            Console.WriteLine(pal.Output(999998));

            //var gen = new PalindromeGeneratorBetter();
            //Console.WriteLine(gen.Output(2562));

            //var stringcheck = new StringChecker();
            //Console.WriteLine(stringcheck.Check("asdf","asd"));

            //var betterStringCheck = new StringCheckerBetter();
            //Console.WriteLine(betterStringCheck.CheckString("This is a test", "This is a test"));

            //var cipher = new CeasarCipher();
            //Console.WriteLine(cipher.Cipher("-27This is a test!"));
        }
    }
}
