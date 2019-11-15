using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculatrice.Model;

namespace Calculatrice.Controler
{
    class Division
    {
        readonly Model.Division div = new Model.Division();
        public double Fct_Div(double A, double B)
        {
            double rslt = div._Div(A, B);

            return rslt;
        }
    }
}
