using System;

namespace Lab_1
{
    class Number
    {
        private string _num1;
    
        public Number()
        {   
            Random rnd = new Random();
            int num2 = Math.Abs(rnd.Next() + rnd.Next() * rnd.Next());
            _num1 = num2.ToString();
        }
        
        public Number(int num2)
        {
            _num1 = num2.ToString();
        }

        public Number(string num2)
        {
            _num1 = num2;
        }

        public string Get()
        {
            return _num1;
        }

        public bool Guessed(string num2)
        {
            for (int i = 0; i < num2.Length; i++)
            {
                if (_num1[i] != num2[i])
                {
                    return false;
                }
            }
            return true;
        }
        
        public void Check(string num2)
        {
            if (num2.Length > _num1.Length)
            {
                Console.WriteLine("Wrong length");
                return;
            }
            
            if (_num1 == num2)
            {
                Console.WriteLine("Yeah");
                return;
            }

            for (int i = 0; i < num2.Length; i++)
            {
                if (_num1[i] == num2[i])
                {
                    Console.Write("B");
                }
            }

            for (int i = 0, j = 0; i < num2.Length-1; i++)
            {
                for (j = 0; j < num2.Length; j++)
                {
                    if (_num1[i] == num2[j] && _num1[i] != num2[i] && _num1[j] != num2[j])
                    {
                        Console.Write("K");
                    }
                }
            }

            Console.WriteLine();
        }
    }

    static class Program
    {
        static void Main()
        {
            Number num = new Number();
            string number;
            Console.WriteLine("Try to guess the number");
            Console.WriteLine($"Length is {num.Get().Length}");
            do
            {
                number = Console.ReadLine();
                num.Check(number);
            } while (!num.Guessed(number) && number != "fuck");

            Console.Write(num.Get());
        }
    }
}