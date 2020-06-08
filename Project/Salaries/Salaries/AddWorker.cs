using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

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
            bool saved =  DBManager.AddWorkerDB(name, surname, gender, DoB, pesel);

            if (saved)
                MessageBox.Show("Worker added successfully");
            else
                MessageBox.Show("Adding worker failed");
        }

        private void SurnameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
