using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    internal class Program
    {
        static void Main(string[] args) {

            int a = 200;
            int b = 50;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            //오버플로우

            int c = 2147483640;
            int d = 52273;

            Console.WriteLine(c + d);

            int e = 2000000000;
            int f = 1000000000;
            Console.WriteLine(e + f);

        }
    }
}
