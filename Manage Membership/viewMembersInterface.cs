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
    
    public partial class ViewMembersInterface : Form
    {
        LibrarianController lc = new LibrarianController();
        public ViewMembersInterface()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void viewMembers_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = lc.getMembershipTypes();
            typecb.DataSource = dt;
            typecb.ValueMember = dt.Columns[0].ToString();
            typecb.DisplayMember = dt.Columns[1].ToString();
            typecb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lc.getCustomerMembershipAll();
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 140;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (typecb.Text != "")
            {
                dataGridView1.DataSource = lc.getCustomerMembershipByMID(Convert.ToInt32(typecb.SelectedValue));
                dataGridView1.Columns[0].Width = 70;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 140;
            }
            else
            {
                MessageBox.Show("Please Select any Type First or Click Search All", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void typecb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msg="";

            string[] array, array1;
            array = lc.membershipReport(out array1);
            for (int i = 0; i < array.Length; i++)
            {
                msg = msg + "Type " + array1[i] + ": " + array[i] + " Customer\n";
            }
            MessageBox.Show("\tMembership Report\t\n\n" + msg, "Report");

        }
    }
}
