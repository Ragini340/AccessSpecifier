using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
    class ProtectedInternalDemo
    {
        protected internal string name = "Ragini Singh";
        protected internal void Msg(string msg)
        {
            Console.WriteLine("Hi " + msg);
        }
    }
    class ProtectedInternalTest
    {
        static void Main(string[] args)
        {
            ProtectedInternalDemo obj = new ProtectedInternalDemo();
            // Accessing protected internal variable
            Console.WriteLine("Hi " + obj.name);

            // Accessing protected internal function  
            obj.Msg(" R, Demo of protected internal");
        }
    }
}
