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
    public partial class DispAllWorkers : Form
    {
        public DispAllWorkers()
        {
            InitializeComponent();

            DispAllWorkersDGV.DataSource = DBManager.DisplayAllDB<Worker>();
        }

        private void ShowSalaries_Click(object sender, EventArgs e)
        {
            var currWorker = DispAllWorkersDGV.SelectedRows[0].DataBoundItem as Worker;

            DisplayAllSalaries displaySalaries = new DisplayAllSalaries(currWorker.WorkerID);
            displaySalaries.Show();
        }
    }
}
