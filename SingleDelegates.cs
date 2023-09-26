using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Delegates
{
    internal class SingleDelegates
    {

        public delegate int MyDelegate(int x, int y);

        public delegate double Delegate1(double x, double y);
        public class Calculation
        {
            public int Addition(int a, int b)
            {
                return a + b;
            }

            public double Division(double a, double b)
            {
                return a / b;
            }
        }
    }


}

