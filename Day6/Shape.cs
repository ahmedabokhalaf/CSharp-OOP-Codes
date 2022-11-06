using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Shape
    {
        public double Dimension { get; set; }
        public double CalcArea()
        {
            return Dimension * Dimension;
        }
    }

    class Square : Shape
    {
        public Square(Square s)
        {
            Dimension = s.Dimension;
        }
        public Square(double dimension)
        {
            Dimension = dimension;
        }
        public Square() : this(1) { }
    }

    class Rectangle : Shape
    {
        public double Dimension2 { get; set; }
        public new double CalcArea()
        {
            return Dimension * Dimension2;
        }
    }

    class Circle : Shape
    {
        public new double CalcArea()
        {
            Dimension /= 2;
            return Math.PI * Dimension * Dimension;
        }
    }
}
