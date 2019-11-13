using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Controler
{
    class Division
    {
        public double Fct_Div(double A, double B)
        {
            double rslt = 0;
            if ( B != 0)
            {
                rslt = A / B;
            }
            return rslt;
        }
    }
}
