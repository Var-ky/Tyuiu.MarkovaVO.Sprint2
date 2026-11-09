using Tyuiu.MarkovaVO.Sprint2.Task2.V16.Lib;

namespace Tyuiu.MarkovaVO.Sprint2.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 12;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
