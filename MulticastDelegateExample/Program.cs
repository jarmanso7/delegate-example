using System;

namespace MulticastDelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var mark = new Mark();

            mark.AddNumbers(3, 3);
            mark.MultiplyNumbers(3, 3);
            mark.SubstractNumbers(3, 3);
        }
    }

    public class Mark
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine($"{nameof(AddNumbers)} : a + b = {a + b}");
        }

        public void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine($"{nameof(AddNumbers)} : a * b = {a * b}");
        }

        public void SubstractNumbers(int a, int b)
        {
            Console.WriteLine($"{nameof(AddNumbers)} : a - b = {a - b}");
        }
    }
}
