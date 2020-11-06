using System;

namespace MulticastDelegateExample
{
    class Program
    {
        delegate int Del(int a, int b);

        static void Main(string[] args)
        {
            var mark = new Mark();

            Del multicastDelegate;

            multicastDelegate = mark.AddNumbers;
            Console.WriteLine("Invoking delegate with one target:");
            multicastDelegate(6, 5);
            Console.WriteLine();

            multicastDelegate += mark.MultiplyNumbers;
            Console.WriteLine("Invoking delegate with two targets:");
            multicastDelegate(6, 5);
            Console.WriteLine();

            multicastDelegate += mark.SubstractNumbers;
            Console.WriteLine("Invoking delegate with three targets:");
            multicastDelegate(6, 5);
            Console.WriteLine();

            multicastDelegate -= mark.MultiplyNumbers;
            Console.WriteLine("Invoking delegate without MultiplyNumbers:");
            multicastDelegate(6, 5);
            Console.WriteLine();
        }
    }

    public class Mark
    {
        public int AddNumbers(int a, int b)
        {
            var sum = a + b;
            Console.WriteLine($"{nameof(AddNumbers)} : a + b = {sum}");
            return sum;
        }

        public int MultiplyNumbers(int a, int b)
        {
            var product = a * b;
            Console.WriteLine($"{nameof(MultiplyNumbers)} : a * b = {product}");
            return product;
        }

        public int SubstractNumbers(int a, int b)
        {
            var substraction = a - b;
            Console.WriteLine($"{nameof(SubstractNumbers)} : a - b = {substraction}");
            return substraction;
        }
    }
}
