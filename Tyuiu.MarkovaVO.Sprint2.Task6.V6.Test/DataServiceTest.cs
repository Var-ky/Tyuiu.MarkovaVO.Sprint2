using Tyuiu.MarkovaVO.Sprint2.Task6.V6.Lib;

namespace Tyuiu.MarkovaVO.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("валет бубен", ds.FindCardNameAndValue(11, 3));
            Assert.AreEqual("туз черви", ds.FindCardNameAndValue(14, 4));
            Assert.AreEqual("шестёрка пик", ds.FindCardNameAndValue(6,1));
            Assert.AreEqual("восмёрка треф", ds.FindCardNameAndValue(8,2));
        }
    }
}
