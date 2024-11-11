using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714230053
{
    public partial class WTEventScheduler : Form
    {
        public WTEventScheduler()
        {
            InitializeComponent();

            genderBox.Items.Add("<Select Gender>");
            genderBox.Items.Add("Male");
            genderBox.Items.Add("Female");

            genderBox.SelectedIndex = 0;
        }

        private void make_Click(object sender, EventArgs e)
        {
            List<string> unit = new List<string>();
            string gamemode = "";
            string time = "";

            if (option1.Checked ==  true)
            {
                unit.Add(option1.Text);
            }
            if (option2.Checked == true)
            {
                unit.Add(option2.Text);
            }
            if (option3.Checked == true)
            {
                unit.Add(option3.Text);
            }
            if (option4.Checked == true)
            {
                unit.Add(option4.Text);
            }

            if (gmoption1.Checked == true)
            {
                gamemode = gmoption1.Text;
            }
            else if (gmoption2.Checked == true)
            {
                gamemode = gmoption2.Text;
            }
            else if (gmoption3.Checked == true)
            {
                gamemode = gmoption3.Text;
            }
            else if (gmoption4.Checked == true)
            {
                gamemode = gmoption4.Text;
            }

            if (tmoption1.Checked == true)
            {
                time = tmoption1.Text;
            }
            else if (tmoption2.Checked == true)
            {
                time = tmoption2.Text;
            }
            else if (tmoption3.Checked == true)
            {
                time = tmoption3.Text;
            }
            else if (tmoption4.Checked == true)
            {
                time = tmoption4.Text;
            }
            else if (tmoption5.Checked == true)
            {
                time = tmoption5.Text;
            }

            if (nameBox.Text.Equals(""))
            {
                MessageBox.Show("Must enter name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (genderBox.SelectedItem.ToString() == "<Select Gender>")
            {
                MessageBox.Show("Must select gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (unit.Count == 0)
            {
                MessageBox.Show("No unit selected.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (gamemode == "")
            {
                MessageBox.Show("Must select a gamemode.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (time == "")
            {
                MessageBox.Show("Must select a schedule.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (unit.Count > 0)
            {
                string unitMessage = "\nUnit: " + string.Join(", ", unit);
                MessageBox.Show(
                    "Name: " + nameBox.Text +
                    "\nGender: " + genderBox.Text +
                    "\nBirthdate: " + birthdateBox.Text + unitMessage +
                    "\nGamemode: " + gamemode +
                    "\nDate and Time: " + time,
                    "War Thunder Even Scheduler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void done_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
