using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    class Customer
    {
        Connection con = new Connection();
        SqlCommand cmd = null;
        string cmdmsg = "Select tbl_BookAssigned.BA_ID as ID,tbl_Customer.Cust_ID as [Customer ID],tbl_Customer.Cust_Name AS [Customer Name],tbl_Book.Book_Name AS [Book Name],tbl_Category.Cat_Name AS [Category],tbl_Author.Auth_Name AS [Author],tbl_BookAssigned.BA_AssignedDate AS [Assigned Date],tbl_BookAssigned.BA_SubmissionDate AS [Submission Date],tbl_BookAssigned.BA_status AS [Status] from tbl_BookAssigned INNER JOIN tbl_Customer ON BA_Cust_ID_f = Cust_ID INNER JOIN tbl_Book on BA_Book_ID_f = Book_ID INNER JOIN tbl_Category ON Book_Cat_ID_f = Cat_ID INNER JOIN tbl_Author ON Book_Auth_ID_f = Auth_ID";

      

        public string assignBookNewCustomer(string name, string contact, string address, DateTime assigndate, DateTime submissiondate, int bookid, int bookqty)
        {
            DataTable dt = new DataTable();
            int custid;
            int mshipid;
            int z;
            try
            {
                cmd = new SqlCommand("Select Mship_ID from tbl_Membership Where Mship_Type = 'None'", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                z = Convert.ToInt32(dt.Rows[0][0]);
                con.Close();

                cmd = new SqlCommand("Insert into tbl_Customer VALUES('" + name + "','" + contact + "','" + address + "'," + z + ");SELECT SCOPE_IDENTITY()", con.Connect());
                custid = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();


                dt = new DataTable();
                cmd = new SqlCommand("Select cust_Mship_ID_f from tbl_Customer where Cust_ID = " + custid + "", con.Connect());
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                mshipid = Convert.ToInt32(dt.Rows[0][0]);

                cmd = new SqlCommand("Insert into tbl_BookAssigned VALUES('" + assigndate + "','" + submissiondate + "'," + 1 + "," + bookid + "," + custid + "," + mshipid + ");SELECT SCOPE_IDENTITY()", con.Connect());
                int baid = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                cmd = new SqlCommand("Insert into tbl_Receipt VALUES(" + bookid + "," + custid + "," + baid + ")", con.Connect());
                cmd.ExecuteNonQuery();
                con.Close();

                updatebookqty(bookid, --bookqty);


                return "Book Successfully Assigned";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string assignBookalreadyCustomer(DateTime assigndate, DateTime submissiondate, int bookid, int customerid, int bookqty)
        {
            int mshipid;
            DataTable dt = new DataTable();
            try
            {
                dt = new DataTable();
                cmd = new SqlCommand("Select cust_Mship_ID_f from tbl_Customer where Cust_ID = " + customerid + "", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                mshipid = Convert.ToInt32(dt.Rows[0][0]);



                cmd = new SqlCommand("Insert into tbl_BookAssigned VALUES('" + assigndate + "','" + submissiondate + "'," + 1 + "," + bookid + "," + customerid + "," + mshipid + ");SELECT SCOPE_IDENTITY()", con.Connect());
                int baid = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                cmd = new SqlCommand("Insert into tbl_Receipt VALUES(" + bookid + "," + customerid + "," + baid + ")", con.Connect());
                cmd.ExecuteNonQuery();
                con.Close();

                updatebookqty(bookid, --bookqty);

                return "Successfully Book Assigned";


            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string receiveBook(int custid, int bookid)
        {
            int bookqty;
            try
            {
                cmd = new SqlCommand("Update tbl_BookAssigned SET BA_status = 0 WHERE BA_Cust_ID_f = " + custid + " AND BA_Book_ID_f = " + bookid + "", con.Connect());
                cmd.ExecuteNonQuery();
                con.Close();

                cmd = new SqlCommand("Select tbl_Book.Book_qty from tbl_BookAssigned INNER JOIN tbl_Book ON BA_Book_ID_f = Book_ID WHERE BA_Cust_ID_f = " + custid + " AND BA_Book_ID_f = " + bookid + " ", con.Connect());
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                bookqty = Convert.ToInt32(dr[0]);


                con.Close();

                updatebookqty(bookid, ++bookqty);
                return "Book Received Successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public DataTable getBookAssigned(int custid)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("Select tbl_Book.Book_ID,tbl_Book.Book_Name from tbl_BookAssigned INNER JOIN tbl_Book ON BA_Book_ID_f = Book_ID WHERE BA_Cust_ID_f = " + custid + " AND Ba_Status = 1", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);



            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            con.Close();
            return dt;

        }

        public string getsubmissiondate(int custid, int bookid)
        {
            try
            {
                cmd = new SqlCommand("Select BA_SubmissionDate from tbl_BookAssigned WHERE BA_Cust_ID_f = " + custid + " AND BA_Book_ID_f = " + bookid + "", con.Connect());
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string date = dr[0].ToString();
                con.Close();
                return date;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public DataTable getCustomerAll()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand(cmdmsg, con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }

            con.Close();
            return dt;


        }

        public DataTable getCustomerByCategory(int catid)
        {
            DataTable dt = new DataTable();
            try
            {
                cmdmsg = cmdmsg + " WHERE tbl_Book.Book_Cat_ID_f = " + catid + "";
                cmd = new SqlCommand(cmdmsg, con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }

            con.Close();
            return dt;


        }


        public DataTable getCustomerByStatus(string status)
        {
            DataTable dt = new DataTable();
            try
            {
                if (status == "Received (0)")
                {
                    cmdmsg = cmdmsg + " WHERE BA_status = 0";
                }
                else if (status == "Not Received (1)")
                {
                    cmdmsg = cmdmsg + " WHERE BA_status = 1";
                }
                cmd = new SqlCommand(cmdmsg, con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }

            con.Close();
            return dt;


        }

        public DataTable getCustomerByCategoryAndStatus(int catid, string status)
        {
            DataTable dt = new DataTable();
            try
            {
                if (status == "Received (0)")
                {
                    cmdmsg = cmdmsg + " WHERE Book_Cat_ID_f = " + catid + " AND BA_status = 0";
                }
                else if (status == "Not Received (1)")
                {
                    cmdmsg = cmdmsg + " WHERE Book_Cat_ID_f = " + catid + " AND BA_status = 1";
                }
                cmd = new SqlCommand(cmdmsg, con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }

            con.Close();
            return dt;


        }

        public DataTable getCustomerByCustomerName(string Name)
        {
            DataTable dt = new DataTable();
            try
            {
                cmdmsg = cmdmsg + " WHERE tbl_Customer.Cust_Name like '%" + Name + "%'";
                cmd = new SqlCommand(cmdmsg, con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }

            con.Close();
            return dt;


        }


        public DataTable getCustomerAddressAndContactNo(int custid)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("Select Cust_Address,Cust_ContactNo from tbl_Customer WHERE Cust_ID = " + custid + "", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return dt;

        }

        public DataTable getCustomerForMembership(string name)
        {
            DataTable dt = new DataTable();
            try
            {

                cmd = new SqlCommand("Select Cust_ID AS [Customer ID],Cust_Name AS [Customer Name],Cust_ContactNo AS [Contact Number],Cust_address AS [Address],tbl_Membership.Mship_Type AS [Membership Type] from tbl_Customer INNER JOIN tbl_Membership ON Cust_Mship_ID_f=Mship_ID Where Cust_Name Like '%" + name + "%'", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);



            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            con.Close();
            return dt;
        }




        private void updatebookqty(int id, int qty)
        {
            try
            {
                cmd = new SqlCommand("UPDATE tbl_Book SET Book_Qty = " + qty + " WHERE Book_ID = " + id + "", con.Connect());
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }


        }


    }
}
