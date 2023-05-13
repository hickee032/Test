using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOperator
{
    internal class Program
    {
        static void Main(string[] args) {

            int output = 0;
            output = output+ 52;
            output = output + 273;
            output = output + 103;

            Console.WriteLine(output);

            int output1 = 0;
            output1 += 52;
            output1 += 273;
            output1 += 103;

            Console.WriteLine(output1);

            string strOutput = "hello";
            strOutput += "World";
            strOutput += "!!";

            Console.WriteLine(strOutput);

        }
    }
}
