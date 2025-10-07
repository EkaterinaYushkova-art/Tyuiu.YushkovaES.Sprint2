using Tyuiu.YushkovaES.Sprint2.Task4.V10.Lib;
namespace Tyuiu.YushkovaES.Sprint2.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 1.061;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 69.167;
            Assert.AreEqual(wait, res);
        }
    }
}
