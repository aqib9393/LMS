using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class CreateAccountInterface : Form
    {
        public CreateAccountInterface()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome h = new AdminHome();
            h.Show();
            this.Hide();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void pwtb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (pwtb1.Text == "")
            {
                MessageBox.Show("Please Enter Password (in the above field) first", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                pwtb1.Focus();
                pwtb2.Text = "";
            }
           
        }

        private void pwtb2_TextChanged(object sender, EventArgs e)
        {

            if (pwtb1.Text == pwtb2.Text)
            {
                status.BackColor = Color.LightGreen;

            }
            else if (pwtb1.Text != pwtb2.Text)
            {
                status.BackColor = Color.Red;
            }
        }

        private void pwtb1_TextChanged(object sender, EventArgs e)
        {
            if (pwtb1.Text == pwtb2.Text)
            {
                status.BackColor = Color.LightGreen;

            }
            else if (pwtb1.Text != pwtb2.Text)
            {
                status.BackColor = Color.Red;
            }


            // To check password Strength.

            if (pwtb1.TextLength >= 1 && pwtb1.TextLength < 4)
            {
                strengthlbl.ForeColor = Color.Red;
                strengthlbl.Text = "Very Weak";
                strengthlbl.Show();
            }
            else if (pwtb1.TextLength == 0)
            {
                strengthlbl.Hide();
            }
            else if (pwtb1.TextLength >=4 && pwtb1.TextLength < 6)
            {
                strengthlbl.ForeColor = Color.YellowGreen;
                strengthlbl.Text = "Weak";

            }
            else if (pwtb1.TextLength >= 6)
            {
                strengthlbl.ForeColor = Color.Green;
                strengthlbl.Text = "Strong";

            }

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (nametb.Text != "" && cnotb.Text != "" && unametb.Text != "" && pwtb1.Text != "" && pwtb2.Text != "")
            {
                string uName = unametb.Text;
                if (!uName.All(char.IsDigit))
                {

                    if (status.BackColor == Color.LightGreen)
                    {
                        if (strengthlbl.Text == "Very Weak")
                        {
                            MessageBox.Show("Password is too Weak", "Weak Password!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            AdminController ac = new AdminController();
                            MessageBox.Show(ac.createLibrarian(nametb.Text, cnotb.Text, unametb.Text, pwtb1.Text));
                            nametb.Clear();
                            cnotb.Clear();
                            unametb.Clear();
                            pwtb1.Clear();
                            pwtb2.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords doesn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Username cannot contain digits only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter all the fields","!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cnotb_Leave(object sender, EventArgs e)
        {
            if (cnotb.TextLength == 11)
            {

            }
            else
            {
                MessageBox.Show("Contact No. must be of 11 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnotb.Focus();
            }
        }

        private void cnotb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void CreateAccountInterface_Load(object sender, EventArgs e)
        {
            strengthlbl.Hide();
        }

        private void nametb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void pwtb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        
        }
    }
}
