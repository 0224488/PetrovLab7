using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
            Console.WriteLine("Введите длину ребра куба");
            int l = Convert.ToInt32(Console.ReadLine());
            cubeSV(l, out long S, out long V);
            Console.WriteLine($"Площадь = {S:N0}");
            Console.WriteLine($"Объём = {V:N0}");
            Console.ReadKey();
        }
        static void cubeSV(int l, out long S, out long V)
        {
            S = l * 12;
            V = (long)Math.Pow(l, 3);
        }
    }
}
