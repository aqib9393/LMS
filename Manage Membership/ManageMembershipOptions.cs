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
    public partial class ManageMembershipOptions : Form
    {
        public ManageMembershipOptions()
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
            ManageMembershipTypeInterface mt = new ManageMembershipTypeInterface();
            mt.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssignAndUpdateMembershipInterface a = new AssignAndUpdateMembershipInterface();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewMembersInterface vm = new ViewMembersInterface();
            vm.Show();

        }

        private void manageMembership_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
