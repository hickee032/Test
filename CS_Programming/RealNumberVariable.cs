using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealNumberVariable
{
    internal class Program
    {
        static void Main(string[] args) {

            double a = 52.273;
            double b = 103.32;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            Console.WriteLine("-------------------------");

            char c = 'a';
            Console.WriteLine(c);

            Console.WriteLine("-------------------------");

            Console.WriteLine("int : "+ sizeof(int));
            Console.WriteLine("long : " + sizeof(long));
            Console.WriteLine("float : " + sizeof(float));
            Console.WriteLine("Double : " + sizeof(double));
            Console.WriteLine("Char : " + sizeof(char));

            Console.WriteLine("-------------------------");

            char d = 'a';
            char e = 'b';
            Console.WriteLine(d + e);
            Console.WriteLine(d - e);
            Console.WriteLine(d * e);
            Console.WriteLine(d / e);
            Console.WriteLine(d % e);
        }
    }
}
