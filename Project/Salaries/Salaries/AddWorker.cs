using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salaries
{
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            string name = NameTB.Text;
            string surname = SurnameTB.Text;
            string gender = GenderTB.Text;
            string DoBs = DoBTB.Text;
            string pesel = PeselTB.Text;

            //regexy do sprawdzenia formatu daty i płci
            //sprawdzanie, czy pesel zgadza się z datą urodzin (ewentualnie)
            //exceptions, np puste pole, zły format daty

            DateTime DoB = DateTime.Parse(DoBs);

            SalariesLINQDataContext db = new SalariesLINQDataContext();

            Worker worker = new Worker() { Name = name, Surname = surname, Gender = gender, DateOfBirth = DoB, Pesel = pesel };
            db.Worker.InsertOnSubmit(worker);

            db.SubmitChanges();
        }

        private void SurnameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
