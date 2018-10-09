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
            //compression.Run();

            //DigitalRoot digitalRoot = new DigitalRoot();
            //digitalRoot.Run(9998);

            //PalindromeGenerator gen = new PalindromeGenerator();
            //Console.WriteLine(gen.Check(22322).ToString());

            //PalindromeGenerator pal = new PalindromeGenerator();
            //Console.WriteLine(pal.output(2562));

            //var gen = new PalindromeGeneratorBetter();
            //Console.WriteLine(gen.Output(334));

            //var stringcheck = new StringChecker();
            //Console.WriteLine(stringcheck.Check("asdf","asd"));

            //var betterStringCheck = new StringCheckerBetter();
            //Console.WriteLine(betterStringCheck.CheckString("This is a test", "This is a test"));

            var cipher = new CeasarCipher();
            Console.WriteLine(cipher.Cipher("-100This is a test."));
        }
    }
}
