using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SAMPLE
{
    public class QuadraticEquation
    {
        private int a;

        public QuadraticEquation(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public int A
        {
            get => a;
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Value of a must be != 0");
                }
                else
                {
                    a = value;
                }
            }
        }

        public int B { get; set; }
        public int C { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Equation: {A}x^2 + {B}x + {C} = 0");
        }

        public int GetRootsCount()
        {
            int discriminant = B * B - 4 * A * C;

            if (discriminant > 0)
                return 2;
            else if (discriminant == 0)
                return 1;
            else
                return 0;
        }

        public double[] GetRoots()
        {
            int discriminant = B * B - 4 * A * C;

            if (discriminant > 0)
            {
                double x1 = (-B + Math.Sqrt(discriminant)) / (2.0 * A);
                double x2 = (-B - Math.Sqrt(discriminant)) / (2.0 * A);
                return new[] { x1, x2 };
            }
            else if (discriminant == 0)
            {
                double x = -B / (2.0 * A);
                return new[] { x };
            }

            return Array.Empty<double>();
        }

    }
}