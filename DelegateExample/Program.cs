using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        delegate int Del(int x, int y);

        static void Main(string[] args)
        {
            var mark = new Mark();

            Del d = mark.AddNumbers;
            Console.WriteLine(d.Invoke(3, 4));

            d = mark.MultiplyNumbers;
            Console.WriteLine(d.Invoke(3, 4));

            d = mark.DoAnotherThing;
            Console.WriteLine(d.Invoke(3, 4));
        }
    }

    public class Mark
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }

        public int DoAnotherThing(int a, int b)
        {
            return a + (b * 3);
        }
    }
}