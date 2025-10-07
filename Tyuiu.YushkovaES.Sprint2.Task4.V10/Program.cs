using Tyuiu.YushkovaES.Sprint2.Task4.V10.Lib;
namespace Tyuiu.YushkovaES.Sprint2.Task4.V10
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
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #10                                                            *");
            Console.WriteLine("* Выполнила: Екатерина Е.С | ИСПб-25-1                                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, вычисляет требуемое значение с использованием      *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение переменных x, y *");
            Console.WriteLine("* с клавиатуры, если x * 2 < y, то                                       *");

            Console.WriteLine("*                         x                                              *");
            Console.WriteLine("*             (      3  )                          (  5  )               *");
            Console.WriteLine("*        z = (  1 + ---  )    иначе    y + 10*x - (  ---  )              *");
            Console.WriteLine("*            (        2  )                         (  x  )               *");
            Console.WriteLine("*             (      y  )                                                *");


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x, y);


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Значение функции z = " + res);
            Console.ReadKey();





        }
    }
}

