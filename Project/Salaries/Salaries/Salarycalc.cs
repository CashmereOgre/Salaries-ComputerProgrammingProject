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
        public double base_sal;
        public double bonus;
        private double seniority = 0; //wysługa
        public int years;
        public double netto;

        public Salarycalc(double bas, double bon, int yrs)
        {
            base_sal = bas;
            bonus = bon;
            years = yrs;
        }
        public void calc_brutto()
        {
            if(years > 4)
            {
                if (years > 20)
                    seniority = base_sal * 0.2;
                else
                    seniority = base_sal * years * 0.01;
            }
            brutto = Math.Round(base_sal, 2) + Math.Round(bonus, 2) + Math.Round(seniority, 2);
        }

        public void calc_netto(double zus, double hc, double tax) 
        {
            netto = brutto - zus - hc - tax;
        }
    }
}
