using System;
using System.Collections.Generic;
using System.Text;

namespace Leason2
{
    public class HMath : Subjects.MMath
    {
        public double Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                System.Console.WriteLine("Ошибка");
                return 0;
            }
            return (double)num1 / num2;
        }
        void test2()
        {
            Sum(5, 7);
            Count(new int[] { 4, 5, 7, 7 });
        }
    }
}
