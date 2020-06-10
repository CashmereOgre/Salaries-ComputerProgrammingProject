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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddWorker addWorker = new AddWorker();
            addWorker.Show();
        }

        private void buttonAS_Click(object sender, EventArgs e)
        {
            ChooseWorker chooseWorker = new ChooseWorker();
            chooseWorker.Show();
        }

        private void ButtonDAS_Click(object sender, EventArgs e)
        {
            DisplayAllSalaries displayAllSalaries = new DisplayAllSalaries();
            displayAllSalaries.Show();
        }
    }
}
