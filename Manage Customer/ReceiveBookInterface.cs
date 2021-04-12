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
    public partial class ReceiveBookInterface : Form
    {
        LibrarianController lc = new LibrarianController();
        int fine;
        int days;
        public ReceiveBookInterface()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void customernametb_TextChanged(object sender, EventArgs e)
        {
            submissiondatetb.Text = "";
            comboBox1.DataSource = null;
            comboBox1.Text = "";


            dataGridView1.DataSource = lc.getCustomerForMembership(customernametb.Text);
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 250;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && comboBox1.Text!="")
            {
                if (submissiondatetb.BackColor == Color.Red)
                {
                    MessageBox.Show("Fine : "+fine+" PKR\nSubmission Delay : "+days+" days\nPer Day Fine : 50 PKR " + lc.receiveBook(Convert.ToInt32(dataGridView1.SelectedCells[0].Value), Convert.ToInt32(comboBox1.SelectedValue)));
                }
                else
                {

                    MessageBox.Show(lc.receiveBook(Convert.ToInt32(dataGridView1.SelectedCells[0].Value), Convert.ToInt32(comboBox1.SelectedValue)));
                }

                comboBox1.DataSource = null;
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select any Book and Customer First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataTable dt = new DataTable();
                dt = lc.getBookAssigned(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
                comboBox1.DataSource = dt;
                comboBox1.ValueMember = dt.Columns[0].ToString();
                comboBox1.DisplayMember = dt.Columns[1].ToString();
                comboBox1.Text = "";

            }
            else
            {
                MessageBox.Show("Please Select any Customer First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void receiveBook_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
                

            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                comboBox1.DataSource = null;
                comboBox1.Text = "";

                DataTable dt = new DataTable();
                dt = lc.getBookAssigned(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
                comboBox1.DataSource = dt;
                comboBox1.ValueMember = dt.Columns[0].ToString();
                comboBox1.DisplayMember = dt.Columns[1].ToString();
                comboBox1.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

       private void comboBox1_TextChanged(object sender, EventArgs e)
       {
           
       }

       private void comboBox1_DisplayMemberChanged(object sender, EventArgs e)
       {
          
       }

       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
       {
          
       }

       private void submitbtn_Click(object sender, EventArgs e)
       {
           
       }

       private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
       {
           if (Convert.ToInt32(comboBox1.SelectedValue) > 0)
           {
               string _date = lc.getsubmissiondate(Convert.ToInt32(dataGridView1.SelectedCells[0].Value), Convert.ToInt32(comboBox1.SelectedValue));
               DateTime d1 = Convert.ToDateTime(_date);
               double ans = lc.forFine(d1);

               if (ans > 0)
               {
                   submissiondatetb.BackColor = Color.Red;
                   submissiondatetb.Text = d1.ToShortDateString().ToString();
                   days = Convert.ToInt32(ans);
                   fine = lc.calculateFine(days);

               }
               else
               {
                   submissiondatetb.BackColor = Color.LightGreen;
                   submissiondatetb.Text = d1.ToShortDateString().ToString();
               }
           }
       }

       private void label6_Click(object sender, EventArgs e)
       {

       }
          
       
       
    }
}
