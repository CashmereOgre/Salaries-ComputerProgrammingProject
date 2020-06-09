using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Salaries
{
    static class DBManager
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);

        public static bool AddWorkerDB(string na, string sur, string gen, DateTime dob, string pes)
        {
            SalariesLINQDataContext db = new SalariesLINQDataContext(con);
            Worker worker = new Worker() 
            { 
                Name = na, 
                Surname = sur, 
                Gender = gen, 
                DateOfBirth = dob, 
                Pesel = pes 
            };

            db.Worker.InsertOnSubmit(worker);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static IQueryable<T> DisplayAllDB<T>() where T: class
        {
            SalariesLINQDataContext db = new SalariesLINQDataContext(con);
            var selectQuery = from emp in db.GetTable<T>()
                              select emp;
            return selectQuery;
        }

        public static bool AddSalaryDB(Worker worker, Salarycalc salaryC, Taxes_and_others TaO, Contributions cont)
        {
            SalariesLINQDataContext db = new SalariesLINQDataContext(con);

            Salary salary = new Salary()
            {
                WorkerID = worker.WorkerID,
                Base_sal = salaryC.base_sal,
                Bonus = salaryC.bonus,
                YearsInWork = salaryC.years,
                ZUS = cont.ZUS,
                HCDeducted = cont.hc_deducted,
                HCAsessed = cont.hc_asessed,
                WorksInLiveCity = TaO.otherCity,
                TaxPercent = TaO.tax_precent,
                TaxRelief = TaO.relief,
                Tax = TaO.tax_complete,
                Brutto = salaryC.brutto,
                Netto = salaryC.netto,
                DateOfContributing = DateTime.Now
            };

            db.Salary.InsertOnSubmit(salary);

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
