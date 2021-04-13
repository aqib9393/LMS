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
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into sugg values('"+book.Text+"', '"+suggest.Text+"')";
            new Suggest().ADU(query, dataGridView1);
            MessageBox.Show("insert");
        }
    }
}
