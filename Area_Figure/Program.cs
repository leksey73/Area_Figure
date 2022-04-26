using Area_Figure.Interfaces;
using Area_Figure.Models;
using System;

namespace Area_Figure
{
    internal class Program
    {
        static void GetArea(IArea havearea)
        {
            havearea.Area();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру из приведенного списка:\n1)Треугольник\n2)Круг");
            string name_figure = Console.ReadLine();
            sw1(name_figure);
            Console.ReadLine();
        }
        static void sw1(string s)
        {
            double r, a, b, c;
            switch (s)
            {
                case "1":
                    Console.Write("Введите пожалуйста стороны треугольника:\nСторона A= ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Сторона B= ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Сторона C= ");
                    c = Convert.ToDouble(Console.ReadLine());
                    Triangle three = new Triangle(a, b, c);
                    GetArea(three);
                    break;
                case "2":
                    Console.Write("Введите пожалуйста радиус круга:\nR= ");
                    r = Convert.ToDouble(Console.ReadLine());
                    Circle circ = new Circle(r);
                    GetArea(circ);
                    break;
                default:
                    Console.WriteLine("Фигура из приведенного списка отсутсвует");
                    Console.WriteLine("Сделайте повтор выбора фигуры из приведенного списка:\n1)Треугольник\n2)Круг");
                    string name_figure = Console.ReadLine();
                    sw1(name_figure);
                    break;
            }
        }
    }
}