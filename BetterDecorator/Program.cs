using System;

namespace BetterDecorator
{
    class Program
    {
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
