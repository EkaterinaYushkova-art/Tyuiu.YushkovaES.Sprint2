using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YushkovaES.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {

        public string FindCardNameAndValue(int value1, int value2)
        {
            if (value1 < 1 || value1 > 4)
                throw new ArgumentException("Номер масти должен быть от 1 до 4");

            if (value2 < 6 || value2 > 14)
                throw new ArgumentException("Номер достоинства должен быть от 6 до 14");

            string suitName = GetSuitName(value1);  
            string valueName = GetValueName(value2); 

            return $"{valueName} {suitName}";
        }

        private string GetValueName(int value1)
        {
            return value1 switch
            {
                6 => "шестерка",
                7 => "семерка",
                8 => "восьмерка",
                9 => "девятка",
                10 =>"десятка",
                11 => "валет",
                12 => "дама",
                13 => "король",
                14 => "туз",
                _ => throw new ArgumentException("Неизвестное достоинство карты")
            };
        }

        private string GetSuitName(int value2)
        {
            return value2 switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "черв",
                _ => throw new ArgumentException("Неизвестная масть")
            };
        }
    }
}