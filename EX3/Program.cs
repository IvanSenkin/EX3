using System;

namespace EX3
{
    class Program
    {
        static double distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле
            //r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            //            б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            Console.Write("Введите координату x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("a) Расстояние между двумя точками: " + $"{r:F2}");
            Console.WriteLine("б)* Расстояние между двумя точками: " + $"{distance(x1,y1,x2,y2):F2}");

        }
    }
}
