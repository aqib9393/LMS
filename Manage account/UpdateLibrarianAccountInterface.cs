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
    public partial class UpdateLibrarianAccountInterface : Form
    {
        string lid;
        public UpdateLibrarianAccountInterface(string id,string name,string cno,string password)
        {
            InitializeComponent();
            nametb.Text = name;
            cnotb.Text = cno;
            pwtb.Text = password;
            lid = id;
        }
      


        private void button2_Click(object sender, EventArgs e)
        {
            DeleteLibrarianAccountInterface d = new DeleteLibrarianAccountInterface();
            d.Show();
            this.Hide();
        }

        private void UpdateLibrarianAccountInterface_Load(object sender, EventArgs e)
        {

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

        private void searchbtn_Click(object sender, EventArgs e)
        {
            AdminController ac = new AdminController();
            MessageBox.Show(ac.updateLibrarian(lid, nametb.Text, cnotb.Text, pwtb.Text));
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
    }
}
