﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class surface
    {
        public static double count_surface(int side1 = 0, int side2 = 0, int side3 = 0)
        {
            if (side2 == 0 && side3 == 0) return count_surface_circle(side1);
            else if (side1 * side2 * side3 != 0) return count_surface_triangle(side1, side2, side3);
            else return 0;
        } 
        private static double count_surface_circle(int r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        private static double count_surface_triangle(int a, int b, int c)
        {
            int[] sides = new int[] { a, b, c };
            Array.Sort(sides);
            if (Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 0.000001) return sides[0] * sides[1] / 2;
            double p = (a +b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
