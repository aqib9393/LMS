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
    public partial class AssignAndUpdateMembershipInterface : Form
    {
        LibrarianController lc = new LibrarianController();
        Membership m = new Membership();
        public AssignAndUpdateMembershipInterface()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt = lc.getMembershipTypes();
            typecb.DataSource = dt;
            typecb.ValueMember = dt.Columns[0].ToString();
            typecb.DisplayMember = dt.Columns[1].ToString();

            dt = new DataTable();
            dt = lc.getMembershipTypes1();
            typecb1.DataSource = dt;
            typecb1.ValueMember = dt.Columns[0].ToString();
            typecb1.DisplayMember = dt.Columns[1].ToString();

            typecb.Text = "";
            typecb1.Text = "";
           

        }

        private void typecb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void assignMembership_Load(object sender, EventArgs e)
        {

        }
        public void search()
        {
            dataGridView1.DataSource = lc.getCustomerForMembership(namesearchtb.Text);
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[3].Width = 180;
        }
        private void namesearchtb_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (customernametb.Text != "" && contacttb.Text != "" && addresstb.Text != "" && typecb.Text != "")
            {
                if (contacttb.TextLength == 11)
                {
                    MessageBox.Show(lc.assignMembership(customernametb.Text, contacttb.Text, addresstb.Text, Convert.ToInt32(typecb.SelectedValue)));
                }
                else
                {
                    MessageBox.Show("ContactNo Must be of 11 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please fill properly the required Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                MessageBox.Show(lc.updateCustomerMembership(Convert.ToInt32(dataGridView1.SelectedCells[0].Value),Convert.ToInt32(typecb1.SelectedValue)));
                dataGridView1.DataSource = lc.getCustomerForMembership(namesearchtb.Text);
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 180;
                dataGridView1.Columns[3].Width = 180;
            }
            else
            {
                MessageBox.Show("Please Select any Row First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            
            if(dataGridView1.SelectedRows.Count==1)
            {
               
                MessageBox.Show(m.delete(Convert.ToInt32(dataGridView1.SelectedCells[0].Value)));
                search();
            }
            
            else
            {
                MessageBox.Show("Please Select any Row First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                namesearchtb.Focus();
            }
        }
    }
}
