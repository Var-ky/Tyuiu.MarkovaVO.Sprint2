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
            Assert.AreEqual("валет бубен", ds.FindCardNameAndValue(3, 11));
            Assert.AreEqual("туз черви", ds.FindCardNameAndValue(4, 14));
            Assert.AreEqual("шестёрка пик", ds.FindCardNameAndValue(1,6));
            Assert.AreEqual("восмёрка треф", ds.FindCardNameAndValue(2,8));
        }
    }
}
