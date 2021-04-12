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
    public partial class InsertMembershipInterface : Form
    {
        public InsertMembershipInterface()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageMembershipTypeInterface mt = new ManageMembershipTypeInterface();
            mt.Show();
            this.Close();
        }

        private void titletb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = typetb.Text;
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters are allowed in Membership Type field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void discounttb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = discounttb.Text;
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only digits are allowed in Discount field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            LibrarianController lc = new LibrarianController();
            if (typetb.Text != "" && discounttb.Text != "")
            {
                MessageBox.Show(lc.insertMembership(typetb.Text, int.Parse(discounttb.Text)), "Successful");
            }
            else
            {
                MessageBox.Show("Please Fill Properly The Required Columns", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void updateMembership_Load(object sender, EventArgs e)
        {

        }
    }
}
