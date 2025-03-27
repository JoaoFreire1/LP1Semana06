using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);

            int value = 0;
            for (int i = 0; i < n; i++)
            {  
                value += s.Next(1, 7);
            }

            Console.WriteLine(value);
        }
    }
}
