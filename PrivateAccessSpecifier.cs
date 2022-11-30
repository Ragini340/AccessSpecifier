using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
    class PrivateAccessSpecifier
    {
        private string name = "Ragini Singh";
        private void Msg(string msg)
        {
            Console.WriteLine("Hi " + msg);
        }
    }
    class privateTest
    {
        PrivateAccessSpecifier obj = new PrivateAccessSpecifier();
        // Accessing private variable  
         /*Console.WriteLine("Hi "+obj.name); 

          // Accessing private function  
          obj.Msg(" R");*/
    }
}  

