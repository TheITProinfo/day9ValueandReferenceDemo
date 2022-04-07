using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9ValueandReferenceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n1 = 10;
            //int n2 = n1;
            //n1 = 20;

            //Console.WriteLine("n1={0}",n1);
            //Console.WriteLine("n2={0}",n2);

            Person p1 = new Person();

            p1.Name = "Tom";

            Person p2 = p1;
            p2.Name = p1.Name;

            p1.Name = "Jerry";




            Console.WriteLine("my p1 name is {0}",p1.Name);
            Console.WriteLine("my p2 name is {0}",p2.Name);
            Console.ReadLine();
        }
    }
}
