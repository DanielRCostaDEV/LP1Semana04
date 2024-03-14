using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int n = int.Parse(Console.ReadLine());
            
            // Invoke the GetSpecial method
            Console.WriteLine(GetSpecial(n));
        }

    }
}
