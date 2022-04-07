using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9PolymorphisimVirtualMethodDemo
{
    public class Person
    {


        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("hi, HI ");

              }

        public virtual void Show()
        {
            Console.WriteLine("Hi, I am human");
        }

    }
}
