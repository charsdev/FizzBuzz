using System;
using System.Collections.Generic;

namespace FizzBuzzNS
{
    public class FizzBuzz
    {
        public List<string> GetList(int size)
        {
            var list = new List<string>();
            for (int i = 0; i <= size; i++)
            {
                var o = IsFizz(i);
                o += IsBuzz(i);
                list.Add(o.Length < 1 ? i.ToString() : o);
            }
            return list;
        }

        private string IsFizz(int i) => i % 3 < 1 ? "Fizz" : "";
        private string IsBuzz(int i) => i % 5 < 1 ? "Buzz" : "";
    }

    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            fizzBuzz.GetList(100).ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}
