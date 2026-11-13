using Newtonsoft.Json.Linq;
using Tyuiu.MarkovaVO.Sprint2.Task5.V5.Lib;

namespace Tyuiu.MarkovaVO.Sprint2.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("шестёрка", ds.FindCardValue(6));
            Assert.AreEqual("семёрка", ds.FindCardValue(7));
            Assert.AreEqual("восмёрка", ds.FindCardValue(8));
            Assert.AreEqual("девятка", ds.FindCardValue(9));
            Assert.AreEqual("десятка", ds.FindCardValue(10));
            Assert.AreEqual("валет", ds.FindCardValue(11));
            Assert.AreEqual("дама", ds.FindCardValue(12));
            Assert.AreEqual("король", ds.FindCardValue(13));
            Assert.AreEqual("туз", ds.FindCardValue(14));
        }
        [TestMethod]
        public void TestMethod2()
        {

            DataService ds = new DataService();

            int value = 1;

            try
            {

                ds.FindCardValue(value);


                Assert.Fail();
            }
            catch (ArgumentException ex)
            {



                Assert.IsTrue(ex.Message.Contains("карта должна быть от 6 до 14"));
            }
            catch (Exception ex)
            {

                throw new AssertFailedException($"Ожидалось ArgumentException, но было получено {ex.GetType().Name}: {ex.Message}", ex);
            }
        }
    }
}
