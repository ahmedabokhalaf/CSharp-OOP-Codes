using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Picture
    {
        #region Picture (Composition, Aggregation, and Assocciation)
        //Square s;
        //public Square sqr
        //{
        //    set
        //    {
        //        s = new Square(value);
        //    }
        //    get
        //    {
        //        return new Square(s);
        //    }
        //}
        //public Rectangle rect { get; set; }
        //public double CalcTotalArea()
        //{
        //    double area = sqr.CalcArea(sqr.Dimension) + rect.CalcArea(rect.Dimension, rect.Dimension2);
        //    return area;
        //}
        //public double CalcCirArea(Circle circle)
        //{
        //    return circle.CalcArea(circle.Dimension);
        //}
        #endregion

        #region Picture Array
        //public Square[] Squares { get; set; }
        //public Rectangle[] Rectangles { get; set; }
        //public Picture(int NumSquares, int NumRectangles)
        //{
        //    Squares = new Square[NumSquares];
        //    Rectangles = new Rectangle[NumRectangles];
        //}
        //public double CalcTotalArea()
        //{
        //    double area = 0;
        //    for (int i = 0; i < Squares.Length; i++)
        //    {
        //        area += Squares[i].CalcArea();
        //    }
        //    for (int i = 0; i < Rectangles.Length; i++)
        //    {
        //        area += Rectangles[i].CalcArea();
        //    }
        //    return area;
        //}
        //public double CalcCirArea(Circle circle)
        //{
        //    return circle.CalcArea();
        //}
        #endregion
    }
}
