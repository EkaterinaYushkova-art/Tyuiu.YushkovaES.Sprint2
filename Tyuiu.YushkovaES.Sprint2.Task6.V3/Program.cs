using Tyuiu.YushkovaES.Sprint2.Task6.V3.Lib;
namespace Tyuiu.YushkovaES.Sprint2.Task6.V3
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
            Console.WriteLine("* Составить программу, которая в зависимости от порядкового номера       *");
            Console.WriteLine("* дня недели (1, 2, …, 7) выводит на экран его название                  *");
            Console.WriteLine("* (понедельник, вторник, …, воскресенье).                                *");

            


                Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Введите номер дня недели:");
            int n = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((n < 1) || (n > 7))
            {
                res = "Введено неверное значение";
            }

            else
            {
                res = "Этот день недели:" + ds.FindDayName(n);
            }




            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();


         





        }
    }
}

