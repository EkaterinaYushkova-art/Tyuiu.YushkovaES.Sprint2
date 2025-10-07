﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YushkovaES.Sprint2.Task4.V10.Lib
{
    public class DataService : ISprint2Task4V10
    {
        public double Calculate(double x, double y)
        {
            double z = x * 2 < y ? Math.Pow(1 + (3 / (Math.Pow(y, 2))), x) : y + 10 * x - (5 / x);
            return Math.Round(z, 3);
        }
    }
}
