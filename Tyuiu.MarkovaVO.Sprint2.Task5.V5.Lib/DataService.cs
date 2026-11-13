using System.Net.WebSockets;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MarkovaVO.Sprint2.Task5.V5.Lib
{
    public class DataService : ISprint2Task5V5
    {
        public string FindCardValue(int value)
        {
            string res;
            switch (value)
            {
                case 6:
                    res = "шестёрка";
                    break;
                case 7:
                    res = "семёрка";
                    break;
                case 8:
                    res = "восмёрка";
                    break;
                case 9:
                    res = "девятка";
                    break;
                case 10:
                    res = "десятка";
                    break;
                case 11:
                    res = "валет";
                    break;
                case 12:
                    res = "дама";
                    break;
                case 13:
                    res = "король";
                    break;
                case 14:
                    res = "туз";
                    break;
                default:
                    throw new ArgumentNullException($" карта должна быть от 6 до 14. Значение {value}");
            }
            return res;
        }
    }
}
