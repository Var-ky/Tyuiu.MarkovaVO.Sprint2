using Tyuiu.MarkovaVO.Sprint2.Task7.V9.Lib;

namespace Tyuiu.MarkovaVO.Sprint2.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                   *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                     *");
            Console.WriteLine("* Задание #7                                                                  *");
            Console.WriteLine("* Вариант #9                                                                  *");
            Console.WriteLine("* Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные *");
            Console.WriteLine("* значения) и вычисляет, находится ли точка с координатами X,Y в              *");
            Console.WriteLine("* заштрихованной области.                                                     *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Введите координату X:");
            double  x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
