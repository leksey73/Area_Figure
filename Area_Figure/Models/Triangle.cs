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
            try
            {
                if (A <= 0 || B <= 0 || C <= 0)
                {
                    throw new Exception("Одна из сторон треугольника меньше или равна нулю, такого треугольника не существует!");
                }
                else if (A + B < C || A + C < B || B + C < A)
                {
                    throw new Exception("Неверное соотношение сторон, такого треугольника не существует!");
                }
                else if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) || Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
                {
                    Console.WriteLine("Треугольник прямоугольный.");
                }
                else
                {
                    Console.WriteLine("Треугольник не прямоугольный.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
                Console.ReadKey();
                Console.Clear();
            }

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