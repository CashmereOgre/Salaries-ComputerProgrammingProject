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
    public partial class ChooseWorker : Form
    {
        public ChooseWorker()
        {
            InitializeComponent();

            DispWorkers.DataSource = DBManager.DisplayAllDB<Worker>();
        }

        private void AddNewWorker_Click(object sender, EventArgs e)
        {
            AddWorker addWorker = new AddWorker();
            addWorker.Show();
            DispWorkers.DataSource = DBManager.DisplayAllDB<Worker>();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            DispWorkers.DataSource = DBManager.DisplayAllDB<Worker>();
        }

        private void SelectWorker_Click(object sender, EventArgs e)
        {
            //try
            //{
            var currWorker = DispWorkers.SelectedRows[0].DataBoundItem as Worker;
            //}
            //catch(Exception exc)
            //{
               //MessageBox.Show("No Worker chosen");
            //}
            
            AddSalary addSalary = new AddSalary(currWorker);
            addSalary.Show();
        }
    }
}
