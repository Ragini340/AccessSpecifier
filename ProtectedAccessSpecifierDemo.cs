using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
    class ProtectedAccessSpecifierDemo
    {
        protected string name = "Ragini Singh";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hi " + msg);
        }
    }
    class ProtectedTestDemo : ProtectedAccessSpecifierDemo
    {
        public static void Main(String[] args)
        {
            ProtectedTestDemo obj = new ProtectedTestDemo();
            //Accessing protected variable
            Console.WriteLine("Hi " + obj.name);

            //Now accessing protected function
            obj.Msg(" R, Demo of protected function in derived class.");
        }
    }
}

