using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalNot
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine(!true); 
            Console.WriteLine(!false);
            Console.WriteLine(!(20>100));
            Console.WriteLine(!(20<100));
        }
    }
}
