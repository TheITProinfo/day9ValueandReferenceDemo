using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9ValueandReferenceDemo
{
    class Person
    {
        protected int height;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


    }
}
