using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YushkovaES.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string suit;
            string rank;

            // Определяем масть
            switch (value1)
            {
                case 1:
                    suit = "пик";
                    break;
                case 2:
                    suit = "треф";
                    break;
                case 3:
                    suit = "бубен";
                    break;
                case 4:
                    suit = "червей";
                    break;
                default:
                    throw new ArgumentException($"Номер масти должен быть от 1 до 4. Значение {value1}");
            }

            // Определяем достоинство
            switch (value2)
            {
                case 6:
                    rank = "Шестёрка";
                    break;
                case 7:
                    rank = "Семёрка";
                    break;
                case 8:
                    rank = "Восьмёрка";
                    break;
                case 9:
                    rank = "Девятка";
                    break;
                case 10:
                    rank = "Десятка";
                    break;
                case 11:
                    rank = "Валет";
                    break;
                case 12:
                    rank = "Дама";
                    break;
                case 13:
                    rank = "Король";
                    break;
                case 14:
                    rank = "Туз";
                    break;
                default:
                    throw new ArgumentException($"Номер достоинства карты должен быть от 6 до 14. Значение {value2}");
            }

            // Формируем полное название карты
            return $"{rank} {suit}";
        }
    }
}
