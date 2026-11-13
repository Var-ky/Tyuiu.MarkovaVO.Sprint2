using Tyuiu.MarkovaVO.Sprint2.Task3.V21.Lib;

namespace Tyuiu.MarkovaVO.Sprint2.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                   *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                         *");
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #21                                                                 *");
            Console.WriteLine("* Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с        *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит значение *");
            Console.WriteLine("* переменной X с клавиатуры. Округлить полученное значение до трех знаков     *");
            Console.WriteLine("* после запятой.                                                              *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            double y = ds.Calculate(x);

            Console.WriteLine("Значение Y = " + y);

            Console.ReadKey();
        }
    }
}
