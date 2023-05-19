using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleToString
{
    internal class Program
    {
        static void Main(string[] args) {
            /*
            double num = 3.141592;
            Console.WriteLine(num.ToString("0.0"));
            Console.WriteLine(num.ToString("0.00"));
            Console.WriteLine(num.ToString("0.000"));
            */

            int num = 52273;
            string output = num + "";
            Console.WriteLine(output);

            char a = 'a';
            string output2 = a + "";
            Console.WriteLine(output2);

            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("False"));

            int input = int.MinValue;
            Console.WriteLine(-input);
        }
    }
}
