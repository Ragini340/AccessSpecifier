using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifierPOC
{
    class InternalPOC
    {
        static void Main(string[] args)
        {
            InternalAccessSpecifier obj = new InternalAccessSpecifier();
            // Accessing internal variable  
            Console.WriteLine("Hi " + obj.name);

            // Accessing internal function  
            obj.Msg("Hi R ");
        }
    }
}
