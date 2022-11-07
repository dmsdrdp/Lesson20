using System;

namespace Task1
{
    internal class Program
    {
        delegate double MyDelegate(double r);                                  
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга");
            double r = Convert.ToDouble(Console.ReadLine());

            MyDelegate myDelegate = DCircle;
            double i = myDelegate(r);
            Console.WriteLine($"Длина окружности {i}");

            myDelegate = SCircle;
            i = myDelegate(r);
            Console.WriteLine($"Площадь круга {i}");

            myDelegate = VCircle;
            i = myDelegate(r);
            Console.WriteLine($"Объем шара {i}");

            Console.ReadLine();
        }

        static double DCircle(double r) => 2 * Math.PI * r;                     //метод определяющий длину окружности
        static double SCircle(double r) => Math.PI * Math.Pow(r , 2);           // метод определяющий площадь круга
        static double VCircle(double r) => 4 * Math.PI * Math.Pow(r, 3)/3;      // метод определяющий объем шара
    }
}
