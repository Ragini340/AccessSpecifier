using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
    class ProtectedAccessSpecifier
    {
        protected string name = "Ragini Singh";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hi " + msg);
        }
    }
    class ProtectedTest
    {
        public static void Main(String[] args)
        {
            ProtectedAccessSpecifier obj = new ProtectedAccessSpecifier();
            //Accessing protected variable
            /*Console.WriteLine("Hi " + obj.name);

            //Now accessing protected function
            obj.Msg(" R, protected");*/
        }
    }
}
