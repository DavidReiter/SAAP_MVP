using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAAP_MVP.Model
{
    public class Calc
    {
        public double input { get; set; }

        public double calcSin()
        {
            return Math.Sin(input);
        }

        public double calcCos()
        {
            return Math.Cos(input);
        }
        public double calcTan()
        {
            return Math.Tan(input);
        }

    }
}
