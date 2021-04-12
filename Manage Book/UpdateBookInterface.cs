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
    public partial class UpdateBookInterface : Form
    {
        LibrarianController lc = new LibrarianController();
        string ID, categ, autho;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        public UpdateBookInterface(string _ID, string title, string quantity, string price, string category, string author)
        {
            InitializeComponent();


            ID = _ID;
            titletb.Text = title;
            categ = category;
            autho = author;
            qtytb.Text = quantity;
            pricetb.Text = price;
        }
        public UpdateBookInterface()
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchBookInterface mb = new SearchBookInterface();
            mb.Show();
            this.Close();
        }

        private void categorycb_TextUpdate(object sender, EventArgs e)
        {

        }

        private void authorcb_TextUpdate(object sender, EventArgs e)
        {

        }

        private void categorycb_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = true;
             
        }

        private void authorcb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = authorcb.Text;
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters are allowed in Author field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void pricetb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = pricetb.Text;
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only digits are allowed in Price field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void qtytb_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = qtytb.Text;
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only digits are allowed in Quantity field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void updateBook_Load(object sender, EventArgs e)
        {
            
            
            lc.getAuthorAndCategory(out dt1, out dt2);
            categorycb.DataSource = dt1;
            categorycb.ValueMember = dt1.Columns[0].ToString();
            categorycb.DisplayMember = dt1.Columns[1].ToString();

            authorcb.DataSource = dt2;
            authorcb.ValueMember = dt2.Columns[0].ToString();
            authorcb.DisplayMember = dt2.Columns[1].ToString();

            categorycb.Text = categ;
            authorcb.Text = autho;

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (titletb.Text != "" && categorycb.Text != "" && authorcb.Text != "" && qtytb.Text != "" && pricetb.Text != "")
            {

                if (lc.verifyCategory(dt1, categorycb.Text) && lc.verifyAuthor(dt2, authorcb.Text))
                {

                    MessageBox.Show(lc.updateBook(ID, titletb.Text, categorycb.SelectedValue.ToString(), authorcb.SelectedValue.ToString(), int.Parse(pricetb.Text), int.Parse(qtytb.Text)));
                }
                else if (!lc.verifyCategory(dt1, categorycb.Text) && lc.verifyAuthor(dt2, authorcb.Text))
                {

                    int catid = lc.addBookcategory(categorycb.Text);
                    MessageBox.Show(lc.updateBook(ID, titletb.Text, catid.ToString(), authorcb.SelectedValue.ToString(), int.Parse(pricetb.Text), int.Parse(qtytb.Text)));

                }
                else if (lc.verifyCategory(dt1, categorycb.Text) && !lc.verifyAuthor(dt2, authorcb.Text))
                {
                    int authid = lc.addBookauthor(authorcb.Text);
                    MessageBox.Show(lc.updateBook(ID, titletb.Text, categorycb.SelectedValue.ToString(), authid.ToString(), int.Parse(pricetb.Text), int.Parse(qtytb.Text)));

                }
                else if (!lc.verifyCategory(dt1, categorycb.Text) && !lc.verifyAuthor(dt2, authorcb.Text))
                {
                    int catid = lc.addBookcategory(categorycb.Text);
                    int authid = lc.addBookauthor(authorcb.Text);
                    MessageBox.Show(lc.updateBook(ID, titletb.Text, catid.ToString(), authid.ToString(), int.Parse(pricetb.Text), int.Parse(qtytb.Text)));
                }

            }
            else
            {
                MessageBox.Show("Please Fill Properly The Required Columns", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
