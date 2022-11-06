using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    class Fraction
    {
        public double Numerator { get; set; }
        public double Denominator { get; set; }

        public Fraction() : this(1, 1) { }
        public Fraction(double N,double D) { }

        public static Fraction operator +(Fraction f1,Fraction f2)
        {
            Fraction res = new Fraction();
            res.Denominator = f1.Denominator * f2.Denominator;
            res.Numerator = (f1.Numerator * f2.Denominator) + (f1.Denominator * f2.Numerator);
            return res;
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Denominator = f1.Denominator * f2.Denominator;
            res.Numerator = (f1.Numerator * f2.Denominator) - (f1.Denominator * f2.Numerator);
            return res;
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Denominator = f1.Denominator * f2.Denominator;
            res.Numerator = f1.Numerator * f2.Numerator;
            return res;
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Denominator = f1.Denominator * f1.Numerator;
            res.Numerator = f1.Numerator * f2.Denominator;
            return res;
        }

        public static Fraction operator ++(Fraction fraction)
        {
            Fraction res = new Fraction();
            res.Denominator = fraction.Denominator;
            res.Numerator = fraction.Numerator + fraction.Denominator;
            return res;
        }

        public static Fraction operator --(Fraction fraction)
        {
            Fraction res = new Fraction();
            res.Denominator = fraction.Denominator;
            res.Numerator = fraction.Numerator - fraction.Denominator;
            return res;
        }

        public static bool operator ==(Fraction f1,Fraction f2)
        {
            if(f2.Numerator/f1.Numerator == f2.Denominator / f1.Denominator)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Fraction f1,Fraction f2)
        {
            if (f2.Numerator / f1.Numerator != f2.Denominator / f1.Denominator)
            {
                return true;
            }
            return false;
        }

        public string Print()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
