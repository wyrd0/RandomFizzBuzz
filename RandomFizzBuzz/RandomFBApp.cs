using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFizzBuzz
{
    class RandomFBApp : FizzBuzz
    {

        public void Control()
        {
            string input = GetInput();
            bool go = Go(input);
            while (go && !Console.KeyAvailable)
            {
                int number = GenerateRandomNumbers();
                Console.Write("   " + PrintNumber(number) + "   ");
               
            }
        }
        public bool Go(string input)
        {
            bool go = false;
            if (input == "go")
            { go = true; }
            else { go = false; }
             return go;
        }
        public string GetInput()
        { 
        string input = Console.ReadLine().ToLower();
            return input;
        }
        public int GenerateRandomNumbers()
        {
            Random n = new Random();
            int number = n.Next(1, 100);
            return number;
        }
    }
}
