using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Start:
            Console.WriteLine("\n\n\t++++++++++++++++++++++++++" +
                                "\n\t++                      ++" +
                                "\n\t++      Welcome to      ++" +
                                "\n\t++    Looping System    ++" +
                                "\n\t++                      ++" +
                                "\n\t++++++++++++++++++++++++++\n\n");

            Console.ReadKey();
            Console.Clear();

            string input;
            int num;

            Console.WriteLine("Please Type the String you want to loop");
            input = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Your input is:\n\n" + input);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"How many times do you want to loop {input}?\n");
            while (!int.TryParse(Console.ReadLine(), out num) || num < 1)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
            Console.Clear();

            Console.WriteLine("Press Enter to Proceed");
            Console.ReadKey();
            Console.Clear();

            Loop(input, num);
            Console.ReadKey();
            Console.Clear();
            goto Start;

        }

        static void Loop(string a,int b)
        {
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine($"{i + 1}.) {a}");
            }
        }
    }
}
