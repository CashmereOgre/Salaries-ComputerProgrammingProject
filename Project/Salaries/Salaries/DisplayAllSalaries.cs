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
    public partial class DisplayAllSalaries : Form
    {
        public DisplayAllSalaries()
        {
            InitializeComponent();

            DispAllSalaries.DataSource = DBManager.DisplayAllDB<Salary>();
        }

        public DisplayAllSalaries(int workerID)
        {
            InitializeComponent();

            DispAllSalaries.DataSource = DBManager.DiplayWorkersSalariesDB(workerID);
        }
    }
}
