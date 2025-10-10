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

            // Тестирование валидных значений
            Assert.AreEqual("Шестёрка пик", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("Семёрка треф", ds.FindCardNameAndValue(2, 7));
            Assert.AreEqual("Восьмёрка бубен", ds.FindCardNameAndValue(3, 8));
            Assert.AreEqual("Девятка червей", ds.FindCardNameAndValue(4, 9));
        }

        [TestMethod]
        public void ValidFindCardNameAndValue2()
        {
            DataService ds = new DataService();

            // Тестирование всех карт от 6 до 14
            Assert.AreEqual("Шестёрка пик", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("Семёрка треф", ds.FindCardNameAndValue(2, 7));
            Assert.AreEqual("Восьмёрка бубен", ds.FindCardNameAndValue(3, 8));
            Assert.AreEqual("Девятка червей", ds.FindCardNameAndValue(4, 9));
            Assert.AreEqual("Десятка пик", ds.FindCardNameAndValue(1, 10));  
            Assert.AreEqual("Валет треф", ds.FindCardNameAndValue(2, 11));
            Assert.AreEqual("Дама бубен", ds.FindCardNameAndValue(3, 12));
            Assert.AreEqual("Король червей", ds.FindCardNameAndValue(4, 13));
            Assert.AreEqual("Туз пик", ds.FindCardNameAndValue(1, 14));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidSuitTest()
        {
            DataService ds = new DataService();
            // Ограничение для пользователя: масть должна быть от 1 до 4
            // Этот тест проверяет, что при невалидной масти выбрасывается исключение
            ds.FindCardNameAndValue(0, 6);  // Масть 0 - недопустима
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidSuitTest2()
        {
            DataService ds = new DataService();
            // Ограничение для пользователя: масть должна быть от 1 до 4
            ds.FindCardNameAndValue(5, 7);  // Масть 5 - недопустима
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidRankTest()
        {
            DataService ds = new DataService();
            // Ограничение для пользователя: достоинство должно быть от 6 до 14
            ds.FindCardNameAndValue(1, 5);  // Достоинство 5 - недопустимо
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidRankTest2()
        {
            DataService ds = new DataService();
            // Ограничение для пользователя: достоинство должно быть от 6 до 14
            ds.FindCardNameAndValue(2, 15);  // Достоинство 15 - недопустимо
        }
    }
}
