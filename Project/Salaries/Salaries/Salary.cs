using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salaries
{
    class Salarycalc
    {
        public double brutto;
        private double base_sal;
        private double bonus;
        private double seniority = 0; //wysługa
        private double netto;

        public void calc_brutto(int years)
        {
            if(years > 4)
            {
                if (years > 20)
                    seniority = base_sal * 0.2;
                else
                    seniority = base_sal * years * 0.01;
            }
            brutto = base_sal + bonus + seniority;

        }

        public void calc_netto(double zus, double hc, double tax)
        {
            netto = brutto - hc - tax;
        }
    }
}
