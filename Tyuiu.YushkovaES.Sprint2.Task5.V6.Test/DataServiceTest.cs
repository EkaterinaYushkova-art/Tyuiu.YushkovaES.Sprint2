using Tyuiu.YushkovaES.Sprint2.Task5.V6.Lib;
namespace Tyuiu.YushkovaES.Sprint2.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
      
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            string res1 = ds.FindCardNameAndValue(1, 6);   // value1=1 (пики), value2=6
            string wait1 = "шестерка пик";
            Assert.AreEqual(wait1, res1);

            string res2 = ds.FindCardNameAndValue(2, 11);  // value1=2 (трефы), value2=11
            string wait2 = "валет треф";
            Assert.AreEqual(wait2, res2);

            string res3 = ds.FindCardNameAndValue(3, 12);  // value1=3 (бубны), value2=12
            string wait3 = "дама бубен";
            Assert.AreEqual(wait3, res3);

            string res4 = ds.FindCardNameAndValue(4, 14);  // value1=4 (червы), value2=14
            string wait4 = "туз черв";
            Assert.AreEqual(wait4, res4);
        }

        [TestMethod]
        public void InvalidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            // Неверный value1 (масть)
            Assert.ThrowsException<ArgumentException>(() => ds.FindCardNameAndValue(0, 10));
            Assert.ThrowsException<ArgumentException>(() => ds.FindCardNameAndValue(5, 10));

            // Неверный value2 (достоинство)
            Assert.ThrowsException<ArgumentException>(() => ds.FindCardNameAndValue(1, 5));
            Assert.ThrowsException<ArgumentException>(() => ds.FindCardNameAndValue(1, 15));


        }
    }
}
