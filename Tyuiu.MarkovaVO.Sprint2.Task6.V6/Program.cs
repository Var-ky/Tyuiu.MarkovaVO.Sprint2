using Tyuiu.MarkovaVO.Sprint2.Task6.V6.Lib;

namespace Tyuiu.MarkovaVO.Sprint2.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Маркова В. О | ПИНб-26-1";
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Спринт #2                                                                   *");
            Console.WriteLine("* Тема: Получение результата из switch                                        *");
            Console.WriteLine("* Задание #6                                                                  *");
            Console.WriteLine("* Вариант #6                                                                  *");
            Console.WriteLine("* Выполнила: Маркова Варвара Олеговна | ПИНб-26-1                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* аписать программу, которая использует сокращенную форму записи оператора    *");
            Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат. По заданным     *");
            Console.WriteLine("* номеру масти m (1 <= m <= 4) и номеру достоинства карты k (6 <= k <= 14)    *");
            Console.WriteLine("* определить полное название соответствующей карты в виде «Дама пик» и т.п.   *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************");

            Console.WriteLine("Введите номер достоинства карты:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер масти карты:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************");

            string res = ds.FindCardNameAndValue(k,m);
            Console.WriteLine("Полное название карты: " + res);

            Console.ReadKey();
        }
    }
}
