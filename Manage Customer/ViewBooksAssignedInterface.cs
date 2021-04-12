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
    public partial class ViewBooksAssignedInterface : Form
    {
        LibrarianController lc = new LibrarianController();
        
        public ViewBooksAssignedInterface()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewBookAssigned_Load(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            dt = lc.getBookCategory();
            categorycb.DataSource = dt;
            categorycb.ValueMember = dt.Columns[0].ToString();
            categorycb.DisplayMember = dt.Columns[1].ToString();

            statuscb.Text = "All";
            categorycb.Text = "All";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            statuscb.Text = "All";
            categorycb.Text = "All";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if(categorycb.Text=="All" && statuscb.Text == "All")
            {
            
            dataGridView1.DataSource = lc.getCustomerAll();
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 160;
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[8].Width = 50;
            }
            else if (categorycb.Text != "All" && statuscb.Text == "All")
            {
                
                dataGridView1.DataSource = lc.getCustomerByCategory(Convert.ToInt32(categorycb.SelectedValue));
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[1].Width = 60;
                dataGridView1.Columns[2].Width = 140;
                dataGridView1.Columns[3].Width = 160;
                dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[7].Width = 80;
                dataGridView1.Columns[8].Width = 50;

            }
            else if (categorycb.Text == "All" && statuscb.Text!= "All")
            {
                
                dataGridView1.DataSource = lc.getCustomerByStatus(statuscb.Text);
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[1].Width = 60;
                dataGridView1.Columns[2].Width = 140;
                dataGridView1.Columns[3].Width = 160;
                dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[7].Width = 80;
                dataGridView1.Columns[8].Width = 50;

            }
            else if (categorycb.Text != "All" && statuscb.Text != "All")
            {
                
                dataGridView1.DataSource = lc.getCustomerByCategoryAndStatus(Convert.ToInt32(categorycb.SelectedValue), statuscb.Text);
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[1].Width = 60;
                dataGridView1.Columns[2].Width = 140;
                dataGridView1.Columns[3].Width = 160;
                dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[7].Width = 80;
                dataGridView1.Columns[8].Width = 50;

            }

        }

        private void categorycb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void c(object sender, EventArgs e)
        {

        }

        private void nametb_Enter(object sender, EventArgs e)
        {
            nametb.Text = "";
        }

        private void nametb_ControlRemoved(object sender, ControlEventArgs e)
        {
            nametb.Text = "Enter Customer Name Here";
        }

        private void nametb_TextChanged(object sender, EventArgs e)
        {
            if (nametb.Text != "")
            {
                
                dataGridView1.DataSource = lc.getCustomerByCustomerName(nametb.Text);
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[1].Width = 60;
                dataGridView1.Columns[2].Width = 140;
                dataGridView1.Columns[3].Width = 160;
                dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[7].Width = 80;
                dataGridView1.Columns[8].Width = 50;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                CustomerReceiptInterface r = new CustomerReceiptInterface(Convert.ToInt32(dataGridView1.SelectedCells[0].Value), Convert.ToInt32(dataGridView1.SelectedCells[1].Value), dataGridView1.SelectedCells[2].Value.ToString(), dataGridView1.SelectedCells[3].Value.ToString(), dataGridView1.SelectedCells[4].Value.ToString(), dataGridView1.SelectedCells[5].Value.ToString(), dataGridView1.SelectedCells[6].Value.ToString(), dataGridView1.SelectedCells[7].Value.ToString());
                r.Show();

            }
            else
            {
                MessageBox.Show("Please Select any Record First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
