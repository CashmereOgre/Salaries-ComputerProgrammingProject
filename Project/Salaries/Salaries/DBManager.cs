using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Salaries
{
    static class DBManager
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);

        public static bool AddWorkerDB(string na, string sur, string gen, DateTime dob, string pes)
        {
            SalariesLINQDataContext db = new SalariesLINQDataContext(con);
            Worker worker = new Worker() { Name = na, Surname = sur, Gender = gen, DateOfBirth = dob, Pesel = pes };
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
    }
}
