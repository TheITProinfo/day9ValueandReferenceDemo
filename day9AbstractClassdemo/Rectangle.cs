using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9AbstractClassdemo
{
    public class Rectangle:Shape
    {
        private double _length;

        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        private double _width;

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }
        // constructor method
        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        // override base class abstracr GetArea method
            public override double GetArea()
        {
           return this.Width*this.Length;
        }
        // override  Getperimeter method of base class
        public override double GetPerimeter()
        {
            return (this.Width+this.Length)*2;
        }
    }

    }

