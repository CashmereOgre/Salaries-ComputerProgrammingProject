using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaries
{
    class Contributions
    {
        public double ZUS;
        private double pension;
        private double rental;
        private double sick;

        public double health_cont_base;
        public double hc_deducted; //7.75%
        public double hc_asessed;  //9%

        public void calc_conts(double brutto)
        {
            pension = brutto * 0.0976;
            rental = brutto * 0.015;
            sick = brutto * 0.0245;
            ZUS = pension + rental + sick;
            ZUS = Math.Round(ZUS, 2);
        }

        public void calc_health_conts(double brutto)
        {
            health_cont_base = brutto - ZUS;
            hc_deducted = Math.Round((health_cont_base * 0.0775), 2);
            hc_asessed = Math.Round((health_cont_base * 0.09), 2);
        }
    }
}
