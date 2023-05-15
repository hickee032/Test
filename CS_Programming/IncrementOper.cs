using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementOper
{
    internal class Program
    {
        static void Main(string[] args) {
            int num = 10;
            num++;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);

            Console.WriteLine("--------------------------------");

            Console.WriteLine(num);
            Console.WriteLine(num++);
            Console.WriteLine(num);
            Console.WriteLine(num--);
            Console.WriteLine(num);

            Console.WriteLine("--------------------------------");

            Console.WriteLine(num);
            Console.WriteLine(num); num += 1;
            Console.WriteLine(num); num -= 1;
            Console.WriteLine(num);

            Console.WriteLine("--------------------------------");

            Console.WriteLine(num);
            Console.WriteLine(num++);
            Console.WriteLine(++num);
            Console.WriteLine(num--);
            Console.WriteLine(--num);


        }
    }
}
