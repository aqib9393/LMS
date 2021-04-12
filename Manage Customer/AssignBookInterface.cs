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
    public partial class AssignBookInterface : Form
    {
        LibrarianController lc = new LibrarianController();
        public AssignBookInterface()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      

        private void typecb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void assignBook_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;
        }

        private void namesearchtb_TextChanged(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = lc.getCustomerForMembership(namesearchtb.Text);
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 250;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            dataGridView2.DataSource = lc.searchBookbyUserdefinedName(booknametb.Text);
            dataGridView2.Columns[0].Width = 50;
            dataGridView2.Columns[1].Width = 150;
            dataGridView2.Columns[2].Width = 60;
            
            dataGridView2.Columns[4].Width = 120;
            dataGridView2.Columns[5].Width = 130;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            
            if (customernametb.Text != "" && contacttb.Text != "" && addresstb.Text != "" &&contacttb.TextLength == 11 && dateTimePicker1.Text!="" && dataGridView2.SelectedRows.Count == 1)
            {
                if (Convert.ToInt32(dataGridView2.SelectedCells[2].Value) == 0)
                {
                    MessageBox.Show("Selected Book not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    double d = (dateTimePicker1.Value.Date - DateTime.Now.Date).TotalDays;
                    if (d > 0)
                    {
                        MessageBox.Show(lc.assignBookNewCustomer(customernametb.Text, contacttb.Text, addresstb.Text, DateTime.Today, dateTimePicker1.Value, Convert.ToInt32(dataGridView2.SelectedCells[0].Value), Convert.ToInt32(dataGridView2.SelectedCells[2].Value)), "Successful");
                        dataGridView2.DataSource = null;
                        dateTimePicker1.Value = DateTime.Today;
                    }
                    else
                    {
                        MessageBox.Show("Submission date must be greater than today's date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (customernametb.Text != "" && contacttb.Text != "" && addresstb.Text != "" && dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select any Book First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (customernametb.Text != "" && contacttb.Text != "" && addresstb.Text != "" && contacttb.TextLength != 11 && dateTimePicker1.Text != "" && dataGridView2.SelectedRows.Count == 1)
            {
                MessageBox.Show("Contact Number must be of 11 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Please Fill the required Fields properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void customernametb_KeyPress(object sender, KeyPressEventArgs e)
        {
             
            string a = customernametb.Text;
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters are allowed in Customer Name field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
        }

        private void contacttb_KeyPress(object sender, KeyPressEventArgs e)
        {
             
            string a = contacttb.Text;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Only digits are allowed in Contact Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && dataGridView3.SelectedRows.Count == 1)
            {
                if (Convert.ToInt32(dataGridView3.SelectedCells[2].Value) == 0)
                {
                    MessageBox.Show("Selected Book not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    double d = (dateTimePicker2.Value.Date - DateTime.Now.Date).TotalDays;
                    if (d > 0)
                    {
                        
                        MessageBox.Show(lc.assignBookalreadyCustomer(DateTime.Today, dateTimePicker2.Value, Convert.ToInt32(dataGridView3.SelectedCells[0].Value), Convert.ToInt32(dataGridView1.SelectedCells[0].Value), Convert.ToInt32(dataGridView3.SelectedCells[2].Value)), "Successful");
                        dataGridView3.DataSource = null;
                        dateTimePicker2.Value = DateTime.Today;
                    }
                    else
                    {
                        MessageBox.Show("Submission date must be greater than today's date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select any Book and Customer First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void r(object sender, EventArgs e)
        {

        }

        private void booknametb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            dataGridView3.DataSource = lc.searchBookbyUserdefinedName(booknametb2.Text);
            dataGridView3.Columns[0].Width = 50;
            dataGridView3.Columns[1].Width = 150;
            dataGridView3.Columns[2].Width = 60;
            dataGridView3.Columns[4].Width = 120;
            dataGridView3.Columns[5].Width = 130;
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
