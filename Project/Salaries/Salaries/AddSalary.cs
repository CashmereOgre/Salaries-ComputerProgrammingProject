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
    public partial class AddSalary : Form
    {
        Worker worker;
        public AddSalary(Worker wo)
        {
            InitializeComponent();
            worker = wo;

            //AddSalaryWorker.DataSource = worker; //dodać do DBManager select one worker
            idTB.Text = worker.WorkerID.ToString();
            nameTB.Text = worker.Name;
            surnameTB.Text = worker.Surname;
            genderTB.Text = worker.Gender;
            dobTB.Text = worker.DateOfBirth.ToString();
            peselTB.Text = worker.Pesel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bas = double.Parse(base_salTB.Text);
            int yrs = int.Parse(seniorTB.Text);
            double bon = double.Parse(bonusTB.Text);
            double tax = double.Parse(taxTB.Text);
            bool rel = relief.Checked;
            bool diffCity = anotherCity.Checked;

            bool saved = CalculationManager.calculateEverything(worker, bas, yrs, bon, tax, rel, diffCity);

            if (saved)
                MessageBox.Show("Salary calculated and added successfully");
            else
                MessageBox.Show("Adding or calculating salary failed");
        }
    }
}
