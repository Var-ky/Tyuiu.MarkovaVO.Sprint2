using Tyuiu.MarkovaVO.Sprint2.Task4.V18.Lib;

namespace Tyuiu.MarkovaVO.Sprint2.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                   *");
            Console.WriteLine("* Тема: Тернарный оператор                                                    *");
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #18                                                                 *");
            Console.WriteLine("* Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием   *");
            Console.WriteLine("* тернарного оператораб где оператор вводит значения переменных x, y с        *");
            Console.WriteLine("* клавиатуры, если x * 3 < y - 2, то z = (6+(x-1)/y^3)^x иначе x+10y-1/x      *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            double z = ds.Calculate(x, y);
            Console.WriteLine("Значение z = " + z);

            Console.ReadKey();
        }
    }
}
