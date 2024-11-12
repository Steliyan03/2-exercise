using System;

namespace Homework_uni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string triangle = "";
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            //An _equilateral_ triangle has all three sides the same length. For a shape to be a triangle at all, all sides have to be of length > 0, and the sum of the lengths of any two sides must be greater than or equal to the length of the third side. 
            if (sideA == sideB && sideB == sideC && sideA == sideC && (sideA > 0 && sideB > 0 && sideC > 0) && (sideA<=sideB + sideC || sideB <= sideA + sideC || sideC <= sideA + sideB))
            {
                Console.WriteLine(triangle = "equilateral");
            }
            //An _isosceles_ triangle has at least two sides the same length. For a shape to be a triangle at all, all sides have to be of length > 0, and the sum of the lengths of any two sides must be greater than or equal to the length of the third side.
            else if (sideA == sideB || sideA == sideC || sideB == sideC && (sideA > 0 && sideB > 0 && sideC > 0) && (sideA <= sideB + sideC || sideB <= sideA + sideC || sideC <= sideA + sideB))
            {
                Console.WriteLine(triangle = "isosceles");
            }
            //A _scalene_ triangle has all sides of different lengths. For a shape to be a triangle at all, all sides have to be of length > 0, and the sum of the lengths of any two sides must be greater than or equal to the length of the third side.
            else if (sideA != sideB && sideA != sideC && sideB != sideC && (sideA > 0 && sideB > 0 && sideC > 0) && (sideA <= sideB + sideC || sideB <= sideA + sideC || sideC <= sideA + sideB))
            {
                Console.WriteLine(triangle = "scalene");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
