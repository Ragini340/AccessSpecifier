using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifier
{
    class PublicAccessSpecifier
    {
        public string name = "Ragini Singh";
        public void Msg(string msg)
        {
            Console.WriteLine("Hi" + msg);
        }
    }
    class PublicTest
    {
        static void Main(String[] args)
        {
            PublicAccessSpecifier obj = new PublicAccessSpecifier();
            //Here I am accessing public variable of PublicAccessSpecifier class.
            Console.WriteLine("Hi "+obj.name);

            //Now accessing public function of PublicAccessSpecifier class.
            obj.Msg(" Singh, Public Specifier");
        }
    }
}

