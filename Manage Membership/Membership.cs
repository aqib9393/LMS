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
    class Membership
    {
        Connection con = new Connection();
        SqlCommand cmd = null;

        public DataTable getMembershipTypes()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("Select Mship_ID AS [Membership ID],Mship_Type AS [Membership Type],Mship_DiscountPercent AS [Discount Percentage] from tbl_Membership WHERE Mship_Type <> 'None'", con.Connect());
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

        public DataTable getMembershipTypes1()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("Select Mship_ID AS [Membership ID],Mship_Type AS [Membership Type],Mship_DiscountPercent AS [Discount Percentage] from tbl_Membership", con.Connect());
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

        public string insertMembership(string type, int discount)
        {
            try
            {
                cmd = new SqlCommand("Insert into tbl_Membership VALUES('" + type + "'," + discount + ")", con.Connect());
                cmd.ExecuteNonQuery();
                con.Close();
                return "Successfully Inserted";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public string assignMembership(string name, string contact, string address, int mshipid)
        {
            try
            {
                cmd = new SqlCommand("Insert into tbl_Customer VALUES('" + name + "','" + contact + "','" + address + "'," + mshipid + ")", con.Connect());
                cmd.ExecuteNonQuery();
                con.Close();
                return "Membership Successfully Assigned";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string delete(int id)
        {
            try
            {
                cmd = new SqlCommand("delete from tbl_Customer where Cust_ID="+id+"", con.Connect());
                cmd.ExecuteNonQuery();
                con.Close();
                return "Membership Deleted Successfuly";
            }
            catch (Exception ex)
            {
                string a = ex.Message;
                return "Book Assigned to Member";
            }
           
        }

        public string updateCustomerMembership(int customerID, int mshipID)
        {
            try
            {
                cmd = new SqlCommand("UPDATE tbl_Customer SET Cust_Mship_ID_f = " + mshipID + " Where Cust_ID = " + customerID + "", con.Connect());
                cmd.ExecuteNonQuery();
                con.Close();



            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            return "Membership Updated Successfuly";

        }

        public DataTable getCustomerMembershipAll()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("Select tbl_Customer.Cust_ID AS [Customer ID],tbl_Customer.Cust_Name AS [Customer Name],tbl_Membership.Mship_Type as [Membership] from tbl_Customer INNER JOIN tbl_Membership on Cust_Mship_ID_f = Mship_ID AND tbl_Membership.Mship_Type <> 'None'", con.Connect());
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

        public DataTable getCustomerMembershipByMID(int mshipid)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("Select tbl_Customer.Cust_ID AS [Customer ID],tbl_Customer.Cust_Name AS [Customer Name],tbl_Membership.Mship_Type as [Membership] from tbl_Customer INNER JOIN tbl_Membership on Cust_Mship_ID_f = Mship_ID WHERE Cust_Mship_ID_f = " + mshipid + "", con.Connect());
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



        public string[] membershipReport(out string[] array1)
        {
            DataTable dt = new DataTable();
            string[] array2;
            string[] array3;

            int n;


            try
            {
                cmd = new SqlCommand("Select Count(*) from tbl_Membership WHERE Mship_Type <> 'None'", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();

                n = Convert.ToInt32(dt.Rows[0][0]);
                array1 = new string[n];
                array2 = new string[n];
                array3 = new string[n];


                dt = new DataTable();

                cmd = new SqlCommand("Select Mship_Type,Mship_ID from tbl_Membership WHERE Mship_Type <> 'None'", con.Connect());
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();

                for (int i = 0; i < n; i++)
                {
                    array1[i] = dt.Rows[i][0].ToString();
                    array3[i] = dt.Rows[i][1].ToString();

                }
                for (int i = 0; i < n; i++)
                {
                    dt = new DataTable();
                    cmd = new SqlCommand("Select Count(*) from tbl_Customer WHERE Cust_Mship_ID_f = " + array3[i] + "", con.Connect());
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();
                    array2[i] = dt.Rows[0][0].ToString();

                }




            }
            catch (Exception ex)
            {
                string a = ex.Message;
                array1 = new string[0];
                array2 = new string[0];

            }
            return array2;


        }





















        public DataTable getMembershipTypeAndDiscount(int baid)
        {
            DataTable dt = new DataTable();
            try
            {
                int mshipid;

                cmd = new SqlCommand("Select BA_Mship_ID_f from tbl_BookAssigned WHERE BA_ID = " + baid + "", con.Connect());
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                mshipid = Convert.ToInt32(dr[0]);
                con.Close();

                cmd = new SqlCommand("Select Mship_Type,Mship_DiscountPercent from tbl_Membership WHERE Mship_ID = " + mshipid + "", con.Connect());
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
    }
}
