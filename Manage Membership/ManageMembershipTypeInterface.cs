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
    public partial class ManageMembershipTypeInterface : Form
    {
        public ManageMembershipTypeInterface()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void membershipTypes_Load(object sender, EventArgs e)
        {
            LibrarianController lc = new LibrarianController();
            DataTable dt = new DataTable();
            dt = lc.getMembershipTypes();

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 240;
            dataGridView1.Columns[2].Width = 245;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                InsertMembershipInterface u = new InsertMembershipInterface();
                u.Show();
                this.Close();
            
            
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
