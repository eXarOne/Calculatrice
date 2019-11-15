using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Model
{
    class Division
    {
        public double _Div(double A, double B)
        {
            double rslt = 0;
            if (B != 0)
            {
                rslt = A / B;
            }
            return rslt;
        }
    }
}
