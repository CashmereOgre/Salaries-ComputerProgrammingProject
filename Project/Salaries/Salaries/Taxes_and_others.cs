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
        private double tax_1st_step;
        private double tax_relief;
        private double tax_raw;
        public double tax_complete;

        private double complete_brutto_income;

        public bool relief;

        public void calc_taxes(Contributions cont)
        {
            tax_base = cont.health_cont_base - obtaining_costs;
            //ogólnie to na razie jest 17%, ale od ponad 85 528 zł zarobku brutto NA ROK (tzn jak baza będzie dodana, to musi temu pracownikowi
            //zsumować wszystkie zarobki w tym roku i jeśli do tej pory przekraczają 85 528 to musi wszystkie podatki na nowo przeliczyć)
            if (complete_brutto_income > 85528)
                tax_1st_step = tax_base * 0.32;
            else if (complete_brutto_income > 1000000)
                tax_1st_step = tax_base * 0.36;
            else
                tax_1st_step = tax_base * 0.17;

            if (relief)
                tax_relief = 43.76;
            else
                tax_relief = 0;

            tax_raw = tax_1st_step - tax_relief - cont.hc_deducted;
            tax_complete = Math.Round(tax_raw, MidpointRounding.AwayFromZero);
        }

        private double sum_all_inclomes()
        {
            return 0;
        }
    }
}
