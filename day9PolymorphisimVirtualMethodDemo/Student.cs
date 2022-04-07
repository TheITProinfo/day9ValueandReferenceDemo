using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9PolymorphisimVirtualMethodDemo
{
    class Student:Person

    {
        public override void Show()
        { 
            Console.WriteLine("I am student");
        }
        
    }
}
