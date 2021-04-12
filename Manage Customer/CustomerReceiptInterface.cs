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
    public partial class CustomerReceiptInterface : Form
    {
        public CustomerReceiptInterface(int BA_ID,int custID,string custname,string bookname,string category,string author,string assigneddate,string submissiondate)
        {
            InitializeComponent();
            LibrarianController lc = new LibrarianController();

            baidlbl.Text = "Receipt No: " + BA_ID.ToString();
            customerIDlbl.Text = custID.ToString();
            customernamelbl.Text = custname;
            booknamelbl.Text = bookname;
            booknamelbl2.Text = booknamelbl.Text;
            categorylbl.Text = category;
            authorlbl.Text = author;
           
            DateTime d1, d2;
            int totaldays;

            totaldays = lc.calculateTotalDays(assigneddate, submissiondate, out d1, out d2);

            totaldayslbl.Text = totaldays.ToString();
            submissiondatelbl.Text = d2.Date.ToShortDateString().ToString();
            assigneddatelbl.Text = d1.Date.ToShortDateString().ToString();


            int priceperday;
            string bookid;
            int discountpercent;
            float afterdiscount;

            
            DataTable dt = new DataTable();
            dt = lc.getCustomerAddressAndContactNo(custID);
            addresslbl.Text = dt.Rows[0][0].ToString();
            contactnolbl.Text = dt.Rows[0][1].ToString();

            priceperday = lc.getpriceperdayAndBookID(BA_ID, custID, out bookid);

            priceperdaylbl.Text = priceperday.ToString();
            bookidlbl.Text = bookid;

            dt = new DataTable();
            dt = lc.getMembershipTypeAndDiscount(BA_ID);
            membershiplbl.Text = dt.Rows[0][0].ToString();
            membershipdiscountlbl.Text = dt.Rows[0][1].ToString() + " %";
           
            discountpercent = Convert.ToInt32(dt.Rows[0][1]);
            int totalamount;
            totalamount = lc.calculateTotalAmount(priceperday, totaldays);
            totalamountlbl.Text = totalamount.ToString() + " PKR";


            afterdiscount = lc.getAfterDiscountAmount(discountpercent, totalamount);
            afterdiscountlbl.Text = Convert.ToString(afterdiscount) + " PKR";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void finalamountlbl_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void receipt_Load(object sender, EventArgs e)
        {
            addresslbl.Enabled = false;
        }
    }
}
