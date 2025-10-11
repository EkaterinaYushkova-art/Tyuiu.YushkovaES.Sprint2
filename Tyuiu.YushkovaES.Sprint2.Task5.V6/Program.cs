using Tyuiu.YushkovaES.Sprint2.Task5.V6.Lib;
namespace Tyuiu.YushkovaES.Sprint2.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                     *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:   *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2,масти «бубны» — 3,                 *");
            Console.WriteLine("* масти «червы» — 4, а достоинству карт: «валету» — 11, «даме» — 12,     *");
            Console.WriteLine("* «королю» — 13, «тузу» — 14 (порядковые номера карт остальных достоинств*");
            Console.WriteLine("* соответствуют их названиям: «шестерка», «девятка» и т. п.).            *");
            Console.WriteLine("* По заданным номеру масти m (1 <= m <= 4) и номеру достоинства карты    *");
            Console.WriteLine("* k (6 <= k <= 14) определить полное название (масть и достоинство)      *");
            Console.WriteLine("*  соответствующей карты в виде «Дама пик», Шестерка бубен» и т. п.      *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Введите номер масти карты (1-4):");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Введите номер достоинства карты (6-14):");
            int k = int.Parse(Console.ReadLine());



            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            string result = ds.FindCardNameAndValue(m, k);
            Console.WriteLine($"* Название карты: {result,-55} *");
            Console.ReadKey();





        }
    }
}


