using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_ulong
{
    internal class Program
    {
        static void Main(string[] args) {

            //음수를 사용하지 않을경우에 유용

            uint unsignedInt = 4147483647;
            ulong unsignedLong = 11223372036854775808;

            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);

        }
    }
}
