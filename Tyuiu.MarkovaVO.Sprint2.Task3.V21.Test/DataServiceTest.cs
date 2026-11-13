using Tyuiu.MarkovaVO.Sprint2.Task3.V21.Lib;

namespace Tyuiu.MarkovaVO.Sprint2.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;

            double res = ds.Calculate(x);
            double wait = 242;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;

            double res = ds.Calculate(x);
            double wait = 0.833;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = 1;

            double res = ds.Calculate(x);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -50;

            double res = ds.Calculate(x);
            double wait = -549.98;
            Assert.AreEqual(wait, res);
        }
    }
}
