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
    public partial class DeleteLibrarianAccountInterface : Form
    {
        AdminController ac = new AdminController();
        public DeleteLibrarianAccountInterface()
        {
            InitializeComponent();
        }

        private void DeleteLibrarianAccountInterface_Load(object sender, EventArgs e)
        {
            nametb.Text = "Enter Librarian Name Here....";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            nametb.Text = "";
        }

        private void nametb_ControlRemoved(object sender, ControlEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                UpdateLibrarianAccountInterface u = new UpdateLibrarianAccountInterface(dataGridView1.SelectedCells[0].Value.ToString(), dataGridView1.SelectedCells[1].Value.ToString(), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[4].Value.ToString());
                u.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Select any Row (Only One) First", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ac.getLibrarians("");
        }

        private void nametb_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView1.DataSource = ac.getLibrarians(nametb.Text);
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                MessageBox.Show(ac.deleteLibrarian(dataGridView1.SelectedCells[0].Value.ToString()));
                dataGridView1.DataSource = ac.getLibrarians("");
            }
            else
            {
                MessageBox.Show("Please Select any Row (Only one) First", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
