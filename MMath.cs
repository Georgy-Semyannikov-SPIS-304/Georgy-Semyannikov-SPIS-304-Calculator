using System;
using System.Collections.Generic;
using System.Text;

namespace Subjects
{
    public class MMath : Math
    {
        void test1()
        {
            Sum(4, 5);
        }
        protected int Count(int[] elementArray)
        {
            return elementArray.Count();
        }
        public double Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
