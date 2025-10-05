using Tyuiu.YushkovaES.Sprint2.Task2.V23.Lib;
namespace Tyuiu.YushkovaES.Sprint2.Task2.V23
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
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #23                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения              *");
            Console.WriteLine("* с клавиатуры и вычисляет находится ли точка с координатами X,Y         *");
            Console.WriteLine("* в заштрихованной области.                                              *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите значение x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            if (res)
                Console.WriteLine("Точка находиться в заштрихованной области");
            else
                Console.WriteLine("Точка не находиться в заштрихованной области");
            Console.ReadKey();

        }
    }
}

