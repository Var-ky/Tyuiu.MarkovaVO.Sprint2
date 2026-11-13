using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MarkovaVO.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int m, int k)
        {
            string kart = k switch
            {
                6 => "шестёрка",
                7 => "семёрка",
                8 => "восмёрка",
                9 => "девятка",
                10 => "десятка",
                11 => "валет",
                12 => "дама",
                13 => "король",
                14 => "туз",
                _ => throw new ArgumentNullException($"номер карты должен быть от 6 до 14. Значение {k}")
            };

            string mast = m switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "черви",
                _ => throw new ArgumentNullException($"масть карты должна быть от 1 до 4. Значение {m}")
            };
            return $"{kart} {mast}";
        }
    }
}
