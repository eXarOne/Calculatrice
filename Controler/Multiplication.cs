using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Controler
{
    class Multiplication
    {
        readonly Model.Multiplication mult = new Model.Multiplication();
        public double Fct_Mult(double A, double B)
        {
            double rslt = mult._Mult(A, B);

            return rslt;
        }
    }
}
