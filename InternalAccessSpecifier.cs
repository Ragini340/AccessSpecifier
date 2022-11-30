using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
    class InternalAccessSpecifier
    {
        internal string name = "Ragini Singh";
        internal void Msg(string msg)
        {
            Console.WriteLine("Hi " + msg);
        }
    }
    class InternalTest
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

