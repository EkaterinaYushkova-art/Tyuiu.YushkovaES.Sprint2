using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YushkovaES.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndSuit(int value, int suit)
        {
            if (suit < 1 || suit > 4)
            {
                throw new ArgumentException("Номер масти должен быть от 1 до 4");
            }

            if (value < 6 || value > 14)
            {
                throw new ArgumentException("Номер достоинства должен быть от 6 до 14");
            }

            string valueName = GetValueName(value);
            string suitName = GetSuitName(suit);

            return $"{valueName} {suitName}";
        }

        private string GetValueName(int value)
        {
            switch (value)
            {
                case 6: return "Шестерка";
                case 7: return "Семерка";
                case 8: return "Восьмерка";
                case 9: return "Девятка";
                case 10: return "Десятка";
                case 11: return "Валет";
                case 12: return "Дама";
                case 13: return "Король";
                case 14: return "Туз";
                default: throw new ArgumentException("Неизвестное достоинство карты");
            }
        }

        private string GetSuitName(int suit)
        {
            switch (suit)
            {
                case 1: return "пик";
                case 2: return "треф";
                case 3: return "бубен";
                case 4: return "черв";
                default: throw new ArgumentException("Неизвестная масть");
            }
        }

        public string FindCardNameAndValue(int value1, int value2)
        {
            throw new NotImplementedException();
        }
    }
}