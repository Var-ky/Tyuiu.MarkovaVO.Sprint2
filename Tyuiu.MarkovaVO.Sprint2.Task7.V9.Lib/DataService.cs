using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MarkovaVO.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Sin(x) >= y) && (0.5 >= y) && (y >= 0))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
