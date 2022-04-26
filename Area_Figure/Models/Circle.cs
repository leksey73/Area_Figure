using Area_Figure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Area_Figure.Models
{
    /// <summary>
    /// Сущность Круга с радиусом R
    /// </summary>
    public class Circle : IArea
    {
        public double R { get; set; }

        public Circle(double r = 0)
        {
            R = r;
        }

        /// <summary>
        /// Данный метод для нахождения площади Круга
        /// </summary>
        /// <returns>
        /// Площадь круга S=
        /// </returns>
        public double Area()
        {
            double S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine($"Площадь круга S= {S}\n");
            return S;
        }
    }
}