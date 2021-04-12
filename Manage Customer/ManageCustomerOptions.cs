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
    public partial class ManageCustomerOptions : Form
    {
        public ManageCustomerOptions()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibrarianHome h = new LibrarianHome();
            h.Show();
            this.Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            AssignBookInterface ab = new AssignBookInterface();
            ab.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceiveBookInterface rb = new ReceiveBookInterface();
            rb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewBooksAssignedInterface vc = new ViewBooksAssignedInterface();
            vc.Show();
        }

        private void manageCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}
