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
    public partial class SearchBookInterface : Form
    {
        LibrarianController lc = new LibrarianController();
        public SearchBookInterface()
        {
            InitializeComponent();

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibrarianHome h = new LibrarianHome();
            
            h.Show();
            this.Close();
        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            lc.booksPageLoad(out dt1,out dt2,out dt3);



            Namecb.DataSource = dt1;
            Namecb.ValueMember = dt1.Columns[0].ToString();
            Namecb.DisplayMember = dt1.Columns[1].ToString();

            categorycb.DataSource = dt2;
            categorycb.ValueMember = dt2.Columns[0].ToString();
            categorycb.DisplayMember = dt2.Columns[1].ToString();

            authorcb.DataSource = dt3;
            authorcb.ValueMember = dt3.Columns[0].ToString();
            authorcb.DisplayMember = dt3.Columns[1].ToString();

            Namecb.Text = "All";
            categorycb.Text = "All";
            authorcb.Text = "All";
            
        }

        private void Namecb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            nametb.Text = "";
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Namecb.Text = "All";
            categorycb.Text = "All";
            authorcb.Text = "All";

            nametb.Text = "Enter Title Here";
            dataGridView1.Columns.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();

            

                if (Namecb.Text != "All" && categorycb.Text == "All" && authorcb.Text == "All")
                {

                    dt = lc.searchBookbyTitle(Namecb.SelectedValue.ToString());
                }
                else if (Namecb.Text == "All" && categorycb.Text != "All" && authorcb.Text == "All")
                {
                    dt = lc.searchBookbyCategory(categorycb.SelectedValue.ToString());
                }
                else if (Namecb.Text == "All" && categorycb.Text == "All" && authorcb.Text != "All")
                {

                    dt = lc.searchBookByAuthor(authorcb.SelectedValue.ToString());

                }
                else if (Namecb.Text != "All" && categorycb.Text != "All" && authorcb.Text == "All")
                {

                    dt = lc.searchBookByTitleandCategory(Namecb.SelectedValue.ToString(), categorycb.SelectedValue.ToString());

                }
                else if (Namecb.Text != "All" && categorycb.Text == "All" && authorcb.Text != "All")
                {

                    dt = lc.searchBookByTitleandAuthor(Namecb.SelectedValue.ToString(), authorcb.SelectedValue.ToString());

                }
                else if (Namecb.Text == "All" && categorycb.Text != "All" && authorcb.Text != "All")
                {

                    dt = lc.searchBookByCategoryandAuthor(categorycb.SelectedValue.ToString(), authorcb.SelectedValue.ToString());

                }
                else if (Namecb.Text != "All" && categorycb.Text != "All" && authorcb.Text != "All")
                {

                    dt = lc.searchBookByTitleandCategoryandAuthor(Namecb.SelectedValue.ToString(), categorycb.SelectedValue.ToString(), authorcb.SelectedValue.ToString());

                }
                else
                {

                    dt = lc.searchBookAll();

                }
            
            



            dataGridView1.DataSource = dt;
            DataGridViewColumn column = dataGridView1.Columns[1];
            column.Width = 200;

            DataGridViewColumn column1 = dataGridView1.Columns[4];
            column1.Width = 160;

            DataGridViewColumn column2 = dataGridView1.Columns[5];
            column2.Width = 180;
  
        }

        private void nametb_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                UpdateBookInterface ub = new UpdateBookInterface(dataGridView1.SelectedCells[0].Value.ToString(),dataGridView1.SelectedCells[1].Value.ToString(),dataGridView1.SelectedCells[2].Value.ToString(),dataGridView1.SelectedCells[3].Value.ToString(),dataGridView1.SelectedCells[4].Value.ToString(),dataGridView1.SelectedCells[5].Value.ToString());
                ub.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select any Record First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            AddBookInterface ab = new AddBookInterface();
            ab.Show();
            this.Close();
        }

        private void nametb_ControlRemoved(object sender, ControlEventArgs e)
        {
            nametb.Text = "Enter Book Title Here";
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public void search()
        {
            if (nametb.Text != "")
            {
                DataTable dt = new DataTable();
                dt = lc.searchBookbyUserdefinedName(nametb.Text);
                dataGridView1.DataSource = dt;

                DataGridViewColumn column = dataGridView1.Columns[1];
                column.Width = 200;

                DataGridViewColumn column1 = dataGridView1.Columns[4];
                column1.Width = 160;

                DataGridViewColumn column2 = dataGridView1.Columns[5];
                column2.Width = 180;
            }
        }
        private void nametb_TextChanged(object sender, EventArgs e)
        {
            search();
  
        }

        private void nametb_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                
                int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                new Book().delete(id);
                search();
            }
            else
            {
                MessageBox.Show("Please Select any Record First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
