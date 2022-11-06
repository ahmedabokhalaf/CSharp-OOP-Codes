using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    abstract class Shape
    {
        public double Dimension { get; set; }
        public double Dimension2 { get; set; }
        public abstract double CalcArea();        
    }
    class Square : Shape
    {
        public override double CalcArea()
        {
            return Dimension * Dimension;
        }
    }

    class Rectangle : Shape
    {        
        public override double CalcArea()
        {
            return Dimension * Dimension2;
        }
    }

    class Circle : Shape
    {
        public override double CalcArea()
        {
            Dimension /= 2;
            return Dimension * Dimension * Math.PI;
        }
    }
}
