using Tyuiu.MarkovaVO.Sprint2.Task0.V29.Lib;

namespace Tyuiu.MarkovaVO.Sprint2.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 735;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, false, true, true, false, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}