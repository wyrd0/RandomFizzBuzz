using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFizzBuzz
{
    class RandomFBApp : FizzBuzz
    {

        public void RunWithRandom(Random n)
        {
            string input = GetInput();
            bool go = Go(input);
           
            while (go && !Console.KeyAvailable)
            {
                int number = n.Next(1, 100);
                Console.Write("   " + PrintNumber(number) + "   ");
                            
            }
        }
        public bool Go(string input)
        {
            bool go = false;
            if (input == "go")
            {
                go = true;
                
            }
            return go;
        }
        public void Pause()
        {
            if(Console.KeyAvailable)
            {
                //break;
            }
        }
        public string GetInput()
        { 
        string input = Console.ReadLine().ToLower();
            return input;
        }
        
    }
}
