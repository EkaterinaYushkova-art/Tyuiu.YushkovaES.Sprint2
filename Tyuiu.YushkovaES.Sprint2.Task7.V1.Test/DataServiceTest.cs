using Tyuiu.YushkovaES.Sprint2.Task7.V1.Lib;
namespace Tyuiu.YushkovaES.Sprint2.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
       
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.3;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);

        }
    }
}
