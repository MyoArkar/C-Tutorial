using System;

namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number for input 1");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a number for input 2");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result Add of input 1 and input 2 => " + (x + y));
            Console.WriteLine("Result Subtract of input 1 and input 2 => " + (x - y));
            Console.WriteLine("Result Multiply of input 1 and input 2 => " + (x * y));
            Console.WriteLine("Result Divide of input 1 and input 2 => " + (x / y));
        }
    }
}