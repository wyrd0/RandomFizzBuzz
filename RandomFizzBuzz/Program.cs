﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();        // init only once or  not (even pseudo-)random.
            
            RandomFBApp randomFizzBuzz = new RandomFBApp();
            
            Console.WriteLine("Type 'go' to start the Random FizzBuzz Generator.  \n (Press any key to stop it.)");
            randomFizzBuzz.RunWithRandom(n);
            

        }
    }
}
