using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
    class PrivateAccessSpecifierDemo
    {
        private string name = "Ragini Singh";
        private void Msg(string msg)
        {
            Console.WriteLine("Hi " + msg);
        }
        
        static void Main(string[] args)
        {
            PrivateAccessSpecifierDemo obj = new PrivateAccessSpecifierDemo();
            // Accessing private variable
            
            Console.WriteLine("Hi " + obj.name);
            // Accessing private function  
            obj.Msg("R");
        }
    }
}
