using System;
using System.Collections.Generic;
using LinearAlgebra;

namespace VectorDemo
{
    public static class MathVectorExtension
    {
        public static void Display(this IMathVector vector)
        {
            foreach (double value in vector)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IMathVector vector1 = new MathVector(new double[] { 1, 2, 3 });
            

            Console.WriteLine($"Vec1 Demensions {vector1.Dimensions}");

            Console.WriteLine($"Vec 2Lenght {vector1.Length}");

            Console.WriteLine();
            Console.Write("Vec1    \t");
            vector1.Display();

            IMathVector result1 =  vector1.MultiplyNumber(10);
            Console.Write("Vec1 * 10\t");
            result1.Display();


            Console.WriteLine();
            IMathVector vector2 = new MathVector(new double[] { 2, 3, 4 });
            Console.Write("Vec2       \t");
            vector2.Display();

            IMathVector result2 = vector1.Multiply(vector2);
            Console.Write("Vec2 * Vec1\t");
            result2.Display();


            Console.WriteLine();
            IMathVector vector3 = new MathVector(new double[] { 4, 4, 1 });
            Console.Write("Vec3             \t");
            vector3.Display();
            double result3 = vector1.ScalarMultiply(vector2);
            Console.Write($"Vec2 scalar Vec1\t{result3}");


            Console.WriteLine();
            MathVector v1 = new MathVector(new double[] { 2, 4, 6 });
            MathVector v2 = new MathVector(new double[] { -1, 4, 1 });

            Console.Write("v1\t");
            v1.Display();
            Console.Write("v2\t");
            v2.Display();

            Console.Write("v1 + v2\t");
            (v1 + v2).Display();
            Console.Write("v1 - v2\t");
            (v1 - v2).Display();
            Console.Write("v1 * v2\t");
            (v1 * v2).Display();
            Console.Write("v1 % v2\t");
            Console.WriteLine(v1 % v2);

        }
    }
}
