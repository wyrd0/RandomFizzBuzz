using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomFizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFizzBuzz.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void PrintNumberTest1Is1()
        {
            int input = 1;
            FizzBuzz fb = new FizzBuzz();
            string printOut = fb.PrintNumber(input);
            Assert.AreEqual("1", printOut);
        }
        [TestMethod()]
        public void PrintNumberTest3IsFizz()
        {
            int input = 3;
            FizzBuzz fb = new FizzBuzz();
            string printOut = fb.PrintNumber(input);
            Assert.AreEqual("Fizz", printOut);
        }
        [TestMethod()]
        public void PrintNumberTest5IsBuzz()
        {
            int input = 5;
            FizzBuzz fb = new FizzBuzz();
            string printOut = fb.PrintNumber(input);
            Assert.AreEqual("Buzz", printOut);
        }
        [TestMethod()]
        public void PrintNumberTest15IsFizzBuzz()
        {
            int input = 15;
            FizzBuzz fb = new FizzBuzz();
            string printOut = fb.PrintNumber(input);
            Assert.AreEqual("FizzBuzz", printOut);
        }
        [TestMethod()]
        public void PrintNumberTest41Is41()
        {
            int input = 41;
            FizzBuzz fb = new FizzBuzz();
            string printOut = fb.PrintNumber(input);
            Assert.AreEqual("41", printOut);
        }
        [TestMethod()]
        public void PrintNumberTest30IsFizzBuzz()
        {
            int input = 30;
            FizzBuzz fb = new FizzBuzz();
            string printOut = fb.PrintNumber(input);
            Assert.AreEqual("FizzBuzz", printOut);
        }
        [TestMethod()]
        public void PrintNumberTest99IsFizz()
        {
            int input = 99;
            FizzBuzz fb = new FizzBuzz();
            string printOut = fb.PrintNumber(input);
            Assert.AreEqual("Fizz", printOut);
        }
        [TestMethod()]
        public void PrintNumberTest55IsBuzz()
        {
            int input = 55;
            FizzBuzz fb = new FizzBuzz();
            string printOut = fb.PrintNumber(input);
            Assert.AreEqual("Buzz", printOut);
        }
    }
}