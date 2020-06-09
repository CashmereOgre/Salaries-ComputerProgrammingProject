using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaries
{
    class Taxes_and_others
    {
        private double obtaining_costs; //wyliczyć jak interfejs będzie dodany, 250 if pracownik z tego samego miasta, 300 if z innego
        public double tax_base;
        public double tax_precent;
        private double tax_1st_step;
        private double tax_relief;
        private double tax_raw;
        public double tax_complete;

        public bool relief;
        public bool otherCity;

        public Taxes_and_others(double tax, bool rel, bool city)
        {
            tax_precent = tax;
            relief = rel;
            otherCity = city;
        }

        double calc_obt_costs()
        {
            if (otherCity)
                obtaining_costs = 300;
            else
                obtaining_costs = 250;
            return obtaining_costs;
        }
        public void calc_taxes(Contributions cont)
        {
            tax_base = cont.health_cont_base - calc_obt_costs();

            tax_1st_step = tax_base * tax_precent * 0.01;

            if (relief)
                tax_relief = 43.76;
            else
                tax_relief = 0;

            tax_raw = tax_1st_step - tax_relief - cont.hc_deducted;
            tax_complete = Math.Round(tax_raw, MidpointRounding.AwayFromZero);
        }
    }
}
