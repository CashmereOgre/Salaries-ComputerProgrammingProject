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

        private double health_cont_base;
        private double hc_deducted;
        public double hc_asessed;

        public void calc_conts(double brutto)
        {
            pension = brutto * 0.0976;
            rental = brutto * 0.015;
            sick = brutto * 0.0245;
            ZUS = pension + rental + sick;
        }

        public void calc_health_conts(double brutto, double zus)
        {
            health_cont_base = brutto - zus;
            hc_deducted = health_cont_base * 0.0775;
            hc_asessed = health_cont_base * 0.09;
        }
    }
}
