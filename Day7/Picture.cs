using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Picture
    {
        public Shape[] Shapes { get; set; }
        public Picture(int size)
        {
            Shapes = new Shape[size];
        }
        public double CalcTotalArea()
        {
            double totalArea = 0;
            for(int i = 0; i < Shapes.Length; i++)
            {
                totalArea += Shapes[i].CalcArea();
            }
            return totalArea;
        }
    }
}
