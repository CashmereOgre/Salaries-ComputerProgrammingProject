using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            try
            {
                string name = NameTB.Text;
                string surname = SurnameTB.Text;
                string gender = GenderTB.Text;
                string DoBs = DoBTB.Text;
                string pesel = PeselTB.Text;

                if (name == "" || surname == "" || gender == "" || DoBs == "" || pesel == "")
                    throw new ExceptionNullValue("One or more of input fields are empty");

                string patNameSur = @"[A-Z]\D+";
                Regex regNameSur = new Regex(patNameSur);
                string patGender = @"^[FM]$";
                Regex regGender = new Regex(patGender);
                string patPesel = @"^[0-9]{11}$";
                Regex regPesel = new Regex(patPesel);

                if (!regNameSur.IsMatch(name) || !regNameSur.IsMatch(surname))
                    throw new System.FormatException("Inappropriate Name or Surname format (proper one, f.e. Christopher)");
                if (!regGender.IsMatch(gender))
                    throw new System.FormatException("Inappropriate Gender format (proper one: F or M)");
                if (!regPesel.IsMatch(pesel))
                    throw new System.FormatException("Inappropriate PESEL format (proper one: 11 digits)");

                DateTime DoB = DateTime.Parse(DoBs);
                bool saved = DBManager.AddWorkerDB(name, surname, gender, DoB, pesel);

                if (saved)
                    MessageBox.Show("Worker added successfully");
                else
                    MessageBox.Show("Adding worker failed");
            }
            catch(System.FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch(ExceptionNullValue ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SurnameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
