using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Suggestion
{
    public partial class Suggestion : Form
    {
        public Suggestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ADD().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Delete().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Update().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Search().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new LibrarianLogin().Show();
            this.Hide();
            this.Close();
        }
    }
}
