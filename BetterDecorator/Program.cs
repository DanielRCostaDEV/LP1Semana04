using System;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// receive a string, a char, or a int
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        
        private static string Decor(string s, char dec, int num)
        {
            string destr = ""; 
            for (int i = 0; i < num; i++)
            {
                destr += $"{dec}";
            }
            destr += $"{s}";

            for (int i = 0; i < num; i++)
            {
                destr += $"{dec}";
            }
            return destr;
        }
        
        /// <summary>
        /// Write the string, char or int
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine
                return;
            }

            string text = args[0];
            char decorationChar = args[1][0];
            int times = int.Parse(args[2]);

            Console.WriteLine(Decor(text, decorationChar, times));
        }
    }
}
