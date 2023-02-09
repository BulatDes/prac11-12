using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac_11_12
{
    class Student
    {
        public string name;
        public double rost;
        internal double ves;
        public double eda;

        public void SetEat(double eda)
        {
            if (eda > 5 && eda < 10)
            {
                ves = ves + ((eda * 1000 - 1600) / 1000)%70;
                rost--;
            }
            else if (eda >= 10)
            {
                ves = ves + ((eda * 1000 - 1600) / 1000) % 50;
                rost-=2;
            }
            else
                ves = ves + (eda * 1000 - 1600) / 1000;
        }
        public double GetEat()
        {
            return ves;
        }

    }
}
