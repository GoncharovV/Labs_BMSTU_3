using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinearAlgebra
{
    public class MathVector : IMathVector
    {
        private double[] _coordinates;

        public MathVector(IEnumerable<double> arr)
        {
            this._coordinates = arr.ToArray();
        }

        public MathVector(IMathVector vec)
        {
            _coordinates = new double[vec.Dimensions];
            for (int i = 0; i < _coordinates.Length; i++)
            {
                _coordinates[i] = vec[i];
            }
        }

        public double this[int i] 
        {
            get
            {
                return _coordinates[i];
            }
            set
            {
                _coordinates[i] = value;
            }
        }

        public int Dimensions 
        {
            get { return _coordinates.Length; }
        }

        public double Length {
            get
            {
                return Math.Sqrt(_coordinates.Aggregate((acc, x) => acc + x * x));
            } 
        }

        public double CalcDistance(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
                throw new VectorDimensionsMismatchException();

            return Math.Sqrt(
                _coordinates.Select((x, inx) => Math.Pow(x - vector[inx], 2))
                    .Aggregate((acc, x) => acc + x)
            );
        }

        public IEnumerator GetEnumerator()
        {
            return _coordinates.GetEnumerator();
        }

        public IMathVector Multiply(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
                throw new VectorDimensionsMismatchException ();
      

            return new MathVector(_coordinates.Select((x, inx) => x * vector[inx]));
        }//

        public IMathVector MultiplyNumber(double number)
        {
            return new MathVector( _coordinates.Select(x => x * number) );
        }//

        public double ScalarMultiply(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
                throw new VectorDimensionsMismatchException();

            return _coordinates.Select((x, inx) => x * vector[inx])
                .Aggregate((acc, x) => acc + x);
        }//

        public IMathVector Sum(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
                throw new VectorDimensionsMismatchException();

            return new MathVector(_coordinates.Select((x, inx) => x + vector[inx]));
        }

        /// <summary>
        /// Нахождение покомпонентной разности двух векторов
        /// </summary>
        /// <returns>Новый экземпляр IMathVector</returns>
        public IMathVector Subtract(IMathVector vector)
        {
            if (this.Dimensions != vector.Dimensions)
                throw new VectorDimensionsMismatchException();

            return new MathVector(_coordinates.Select((x, inx) => x + vector[inx]));
        }

        public IMathVector SumNumber(double number)
        {
            return new MathVector(_coordinates.Select(x => x + number));
        }

        /// <summary>
        /// Покомпонентное сложение векторов
        /// </summary>
        /// <returns>Новый экземпляр IMathVector</returns>
        public static IMathVector operator + (MathVector vector1, MathVector vector2)
        {
            return vector1.Sum(vector2);
        }

        /// <summary>
        /// Покомпонентное сложение вектора с числом
        /// </summary>
        /// <returns>Новый экземпляр IMathVector</returns>
        public static IMathVector operator +(MathVector vector1, double number)
        {
            return vector1.SumNumber(number);
        }

        /// <summary>
        /// Покомпонентная разность векторов
        /// </summary>
        /// <returns>Новый экземпляр IMathVector</returns>
        public static IMathVector operator -(MathVector vector1, MathVector vector2)
        {
            return vector1.Subtract(vector2) ;
        }

        /// <summary>
        /// Покомпонентная разность вектора с числом
        /// </summary>
        /// <returns>Новый экземпляр IMathVector</returns>
        public static IMathVector operator -(MathVector vector1, double number)
        {
            return vector1.SumNumber(-number);
        }

        /// <summary>
        /// Покомпонентное умножение векторов
        /// </summary>
        /// <returns>Новый экземпляр IMathVector</returns>
        public static IMathVector operator *(MathVector vector1, MathVector vector2)
        {
            return vector1.Multiply(vector2);
        }

        /// <summary>
        /// Покомпонентное умножение вектора на число
        /// </summary>
        /// <returns>Новый экземпляр IMathVector</returns>
        public static IMathVector operator *(MathVector vector1, double number)
        {
            return vector1.MultiplyNumber(number);
        }

        /// <summary>
        /// Покомпонентное деление вектора на число
        /// </summary>
        /// <returns>Новый экземпляр IMathVector</returns>
        public static IMathVector operator /(MathVector vector1, double number)
        {
            if (number == 0)
            {
                throw new Exception("Zero Dvivision Error");
            }

            return vector1.MultiplyNumber(1/number);
        }

        /// <summary>
        ///  Нахождение скалярного произведения двух векторов
        /// </summary>
        /// <returns>Значение скалярного произведения</returns>
        public static double operator %(MathVector vector1, MathVector vector2)
        {
            return vector1.ScalarMultiply(vector2);
        }

        public static bool operator ==(MathVector vec1, MathVector vec2)
        {
            if (vec1.Dimensions != vec2.Dimensions)
                return false;

            for(int i = 0; i < vec1.Dimensions; i++)
            {
                if (vec1[i] != vec2[i])
                    return false;
            }

            return true;
        }
        public static bool operator !=(MathVector vec1, MathVector vec2)
        {
            if (vec1.Dimensions != vec2.Dimensions)
                return true;

            for (int i = 0; i < vec1.Dimensions; i++)
            {
                if (vec1[i] != vec2[i])
                    return true;
            }

            return false;
        }

        public override bool Equals(object obj)
        {
            return this == (MathVector)obj;
        }
    }
}
