using Area_Figure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Area_Figure.Models
{
    /// <summary>
    /// Сущность треугольника с 3 сторонами
    /// </summary>
    public class Triangle : IArea
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a = 0, double b = 0, double c = 0)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Данный метод для нахождения площади треугольника
        /// </summary>
        /// <returns>
        /// Площадь треугольника S=
        /// </returns>
        public double Area()
        {
            double p = (A + B + C) / 2;
            double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            Console.WriteLine($"Площадь треугольника S= {S}");
            return S;
        }
    }
}