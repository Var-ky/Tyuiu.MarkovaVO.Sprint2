using Tyuiu.MarkovaVO.Sprint2.Task5.V5.Lib;

namespace Tyuiu.MarkovaVO.Sprint2.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                   *");
            Console.WriteLine("* Тема: Оператор switch                                                       *");
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #5                                                                  *");
            Console.WriteLine("* Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* аписать программу, которая использует оператор switch вычисляет требуемое   *");
            Console.WriteLine("* значение и возвращает результат. Условие:  По заданному номеру карты k      *");
            Console.WriteLine("* (6 <=k <= 14) определить достоинство соответствующей карты.                 *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Введите значение номера карты:");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            string res = ds.FindCardValue(value);
            Console.WriteLine("Достоинство соответствующей карты: " + res);

            Console.ReadKey();
        }
    }
}
