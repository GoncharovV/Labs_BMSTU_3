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
            IMathVector vector1 = new MathVector(new List<double>() { 1, 2, 3 });
            

            Console.WriteLine($"Demensions {vector1.Dimensions}");

            Console.WriteLine($"Lenght {vector1.Length}");

            IMathVector result1 =  vector1.MultiplyNumber(10);
            result1.Display();


            IMathVector vector2 = new MathVector(new List<double>() { 2, 3, 4 });

            IMathVector result2 = vector1.Multiply(vector2);
            result2.Display();




        }
    }
}
