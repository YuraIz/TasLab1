using System;
using System.Collections;

namespace Lab_1
{
    class Test
    {
        private string number;

        public Test(string num)
        {
            number = num;
        }
        public void Check(string b)
        {
            if (number == b)
            {
                Console.WriteLine("Yeah");
            }
            else
            {
                Console.WriteLine("Nope");
            }
        }
    }
    class Program
    {
        static void Main()
        {   
            Test num = new Test("2048");
            
            Console.WriteLine("Try to guess a number");
            for (var i = 0; i < 5; i++)
            {
                var number = Console.ReadLine();
                num.Check(number);
            }
        }
    }
}