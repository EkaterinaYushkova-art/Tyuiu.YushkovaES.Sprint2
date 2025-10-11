using Tyuiu.YushkovaES.Sprint2.Task7.V1.Lib;
namespace Tyuiu.YushkovaES.Sprint2.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Екатерина Е.С | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные          *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка                *");
            Console.WriteLine("*с координатами X,Y в заштрихованной области.                            *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.Write("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine($"* Точка с координатами ({x}, {y}) находится в заштрихованной области *");
            }
            else
            {
                Console.WriteLine($"* Точка с координатами ({x}, {y}) НЕ находится в заштрихованной области *");
            }


            Console.ReadKey();



        }
    }
}
