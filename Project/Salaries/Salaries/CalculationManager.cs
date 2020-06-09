using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaries
{
    static class CalculationManager
    {
        public static void calculateEverything(double bas, int yrs, double bon, double tax, bool rel, bool city)
        {
            Salarycalc salaryCalc = new Salarycalc(bas, bon, yrs);
            salaryCalc.calc_brutto();

            Contributions contributions = new Contributions();
            contributions.calc_conts(salaryCalc.brutto);
            contributions.calc_health_conts(salaryCalc.brutto);

            Taxes_and_others TaO = new Taxes_and_others(tax, rel, city);
            TaO.calc_taxes(contributions);

            salaryCalc.calc_netto(contributions.ZUS, contributions.hc_asessed, TaO.tax_complete);
        }
    }
}
