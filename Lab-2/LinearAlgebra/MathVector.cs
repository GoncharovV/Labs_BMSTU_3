using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinearAlgebra
{
    public class MathVector : IMathVector
    {
        private double[] _list;

        public MathVector(IEnumerable<double> arr)
        {
            this._list = arr.ToArray();
        }

        public double this[int i] 
        {
            get
            {
                return _list[i];
            }
            set
            {
                _list[i] = value;
            }
        }

        public int Dimensions 
        {
            get { return _list.Length; }
        }

        public double Length {
            get
            {
                return Math.Sqrt(_list.Aggregate((acc, x) => acc + x * x));
            } 
        }

        public double CalcDistance(IMathVector vector)
        {
            return Math.Sqrt(
                _list.Select((x, inx) => Math.Pow(x - vector[inx], 2))
                .Aggregate((acc, x) => acc + x)
            );
        }

        public IEnumerator GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public IMathVector Multiply(IMathVector vector)
        {
            return new MathVector(_list.Select((x, inx) => x * vector[inx]));
        }

        public IMathVector MultiplyNumber(double number)
        {
            return new MathVector( _list.Select(x => x * number) );
        }

        public double ScalarMultiply(IMathVector vector)
        {
            return _list.Select((x, inx) => x * vector[inx])
                .Aggregate((acc, x) => acc + x);
        }

        public IMathVector Sum(IMathVector vector)
        {
            return new MathVector(_list.Select((x, inx) => x + vector[inx]));
        }

        public IMathVector Subtract(IMathVector vector)
        {
            return new MathVector(_list.Select((x, inx) => x + vector[inx]));
        }

        public IMathVector SumNumber(double number)
        {
            return new MathVector(_list.Select(x => x + number));
        }

        public static IMathVector operator + (MathVector vector1, MathVector vector2)
        {
            return vector1.Sum(vector2);
        }

        public static IMathVector operator +(MathVector vector1, double number)
        {
            return vector1.SumNumber(number);
        }

        public static IMathVector operator -(MathVector vector1, MathVector vector2)
        {
            return vector1.Subtract(vector2) ;
        }

        public static IMathVector operator -(MathVector vector1, double number)
        {
            return vector1.SumNumber(-number);
        }

        public static IMathVector operator *(MathVector vector1, MathVector vector2)
        {
            return vector1.Multiply(vector2);
        }

        public static IMathVector operator *(MathVector vector1, double number)
        {
            return vector1.MultiplyNumber(number);
        }

        public static IMathVector operator /(MathVector vector1, double number)
        {
            return vector1.MultiplyNumber(1/number);
        }

        public static double operator %(MathVector vector1, MathVector vector2)
        {
            return vector1.ScalarMultiply(vector2);
        }
    }
}
