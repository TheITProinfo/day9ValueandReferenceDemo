using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9PolymorphisimVirtualMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Show();
            Student st1 = new Student();
            st1.Show();

            Console.ReadLine();
        }
    }
}
