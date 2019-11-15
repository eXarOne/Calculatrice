using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Controler
{
    class Addition
    {
        readonly Model.Addition add = new Model.Addition();
        public double Fct_Add(double A, double B)
        {
            double rslt = add._Add(A,B);

            return rslt;
        }
    }
}
