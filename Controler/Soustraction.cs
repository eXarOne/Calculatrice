using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice.Controler
{
    class Soustraction
    {
        readonly Model.Soustraction sous = new Model.Soustraction();
        public double Fct_Sous(double A, double B)
        {
            double rslt = sous._Sous(A, B);

            return rslt;
        }
    }
}
