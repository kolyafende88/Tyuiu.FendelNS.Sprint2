using Tyuiu.FendelNS.Sprint2.Task4.V22.Lib;
namespace Tyuiu.FendelNS.Sprint2.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 39.5;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 22;
            double res = ds.Calculate(x, y);
            double wait = 0.070;
            Assert.AreEqual(res, wait);
        }
    }
}