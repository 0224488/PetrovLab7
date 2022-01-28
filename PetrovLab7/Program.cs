using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше 
            (создать метод для вычисления  площади  треугольника по длинам его сторон). */
            double[] box = new double[2];
            for (int q = 0; q < 2; q++)
            {
                triangleSum(q + 1, out double S);
                box[q] = S;
            }
            if (box[0] == box[1])
            {
                Console.WriteLine("Площади треугольников равны");
            }
            else if (box[0] < box[1])
            {
                Console.WriteLine("Площадь 2-го треугольника больше");
            }
            else
            {
                Console.WriteLine("Площадь 1-го треугольника больше");
            }
            Console.ReadKey();
        }
        static void triangleSum(int a, out double S)
        {
            int f0;
            int[] triangle = new int[3];
            do  // Цикл для проверки правильности введенных длин и повторного ввода в случае ошибки
            {
                Console.WriteLine($"Введите длины сторон {a}-го треугольника");
                for (int i = 0; i < 3; i++)  // Цикл для ввода длин сторон треугольника в массив
                {
                    triangle[i] = Convert.ToInt32(Console.ReadLine());
                }
                if ((triangle[0] + triangle[1] >= triangle[2]) && (triangle[0] + triangle[2] >= triangle[1]) && (triangle[1] + triangle[2] >= triangle[0]))
                // Проверяем могут ли эти отрезки быть сторонами одного треугольника
                {
                    f0 = 0;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода! Отрезки с такими длинами не могут быть сторонами одного треугольника");
                    f0 = 1;
                }
            } while (f0 != 0); // Мучаемcя до тех пор, пока не будут введены правильные длины отрезков

            double P = (triangle[0] + triangle[1] + triangle[2]) / 2;
            S = Math.Sqrt(P * (P - triangle[0]) * (P - triangle[1]) * (P - triangle[2]));
            Console.WriteLine($"Площадь {a}-го треугольника = {S:f2}");
        }
    }
}
