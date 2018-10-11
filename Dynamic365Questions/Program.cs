using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic365Questions
{
    // This project demonstrates solutions to sample whiteboarding questions. See the initial comment at the top of each class
    // to see the problem being solved.

    class Program
    {
        static void Main(string[] args)
        {
            // Comment/uncomment instantiation/method statement pairs to see demonstration
            // of each class.

            //StringCompression compression = new StringCompression();
            //compression.Run("Compresss thiiiiis message");

            //DigitalRoot digitalRoot = new DigitalRoot();
            //digitalRoot.Run(109);

            //PalindromeGenerator pal = new PalindromeGenerator();
            //Console.WriteLine(pal.Output(999998));

            //var gen = new PalindromeGeneratorBetter();
            //Console.WriteLine(gen.Output(2562));

            //var stringcheck = new StringChecker();
            //Console.WriteLine(stringcheck.Check("asdf","asd"));

            //var betterStringCheck = new StringCheckerBetter();
            //Console.WriteLine(betterStringCheck.CheckString("This is a test", "This is a test"));

            //var cipher = new CeasarCipher();
            //Console.WriteLine(cipher.Cipher("-27This is a test!"));

            //var longSubS = new LongestSubstring();
            //longSubS.Run("The rain in Spain stays mainly in the plain.");

            //Console.WriteLine(LongestSubstringBetter.GetLongestSub("abccdefg"));

            //var findSum = new Target();
            //findSum.Run(new int[]{ 3, 1, 2, 4}, 5);

            var angleFinder = new ClockAngle();
            Console.WriteLine(angleFinder.Angle(DateTime.Now));
        }
    }
}
