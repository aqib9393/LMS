using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    class Book
    {
        protected SqlCommand cmd = null;
        
        string cmdmsgforbooks = "Select tbl_Book.Book_ID AS [Book ID],tbl_Book.Book_Name AS [Book Title],tbl_Book.Book_Qty AS [Book Quantity],tbl_Book.Book_PerDayPrice AS [Book Per Day Price],tbl_Category.Cat_Name AS [Category],tbl_Author.Auth_Name AS [Author] from tbl_Book INNER JOIN tbl_Category ON Book_Cat_ID_f=Cat_ID INNER JOIN tbl_Author ON Book_Auth_ID_f=Auth_ID";
        Connection conn = new Connection();

      

        //For Searching

        public DataTable searchBookAll()
        {

            DataTable dt = new DataTable();

            try
            {
                cmd = new SqlCommand(cmdmsgforbooks, conn.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }
            conn.Close();
            return dt;


        }

        public DataTable searchBookbyUserdefinedName(string title)
        {
            DataTable dt = new DataTable();
            string query = "Select tbl_Book.Book_ID AS [Book ID],tbl_Book.Book_Name AS [Book Title],tbl_Book.Book_Qty AS [Book Quantity],tbl_Book.Book_PerDayPrice AS [Book Per Day Price],tbl_Category.Cat_Name AS [Category],tbl_Author.Auth_Name AS [Author] from tbl_Book INNER JOIN tbl_Category ON Book_Cat_ID_f=Cat_ID INNER JOIN tbl_Author ON Book_Auth_ID_f=Auth_ID WHERE tbl_Book.Book_Name like '%" + title + "%'";
            //cmdmsgforbooks = cmdmsgforbooks + " WHERE tbl_Book.Book_Name like '%" + title + "%'";
            try
            {
                cmd = new SqlCommand(query, conn.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }
            conn.Close();
            return dt;
        }

        public DataTable searchBookbyTitle(string title)
        {

            DataTable dt = new DataTable();
            cmdmsgforbooks = cmdmsgforbooks + " WHERE tbl_Book.Book_ID = " + title + "";
            try
            {
                cmd = new SqlCommand(cmdmsgforbooks, conn.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }
            conn.Close();
            return dt;

        }

        public DataTable searchBookbyCategory(string cat)
        {
            DataTable dt = new DataTable();
            cmdmsgforbooks = cmdmsgforbooks + " WHERE Book_Cat_ID_f = " + cat + "";
            try
            {
                cmd = new SqlCommand(cmdmsgforbooks, conn.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }
            conn.Close();
            return dt;

        }

        public DataTable searchBookByAuthor(string auth)
        {
            DataTable dt = new DataTable();
            cmdmsgforbooks = cmdmsgforbooks + " WHERE Book_Auth_ID_f = " + auth + "";
            try
            {
                cmd = new SqlCommand(cmdmsgforbooks, conn.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }
            conn.Close();
            return dt;
        }

        public DataTable searchBookByTitleandCategory(string title, string cat)
        {
            cmdmsgforbooks = cmdmsgforbooks + " WHERE Book_ID = " + title + " AND Book_Cat_ID_f = " + cat + "";
            DataTable dt = new DataTable();

            try
            {
                cmd = new SqlCommand(cmdmsgforbooks, conn.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }
            conn.Close();
            return dt;
        }

        public DataTable searchBookByTitleandAuthor(string title, string auth)
        {
            DataTable dt = new DataTable();
            cmdmsgforbooks = cmdmsgforbooks + " WHERE Book_ID = " + title + " AND Book_Auth_ID_f = " + auth + "";
            try
            {
                cmd = new SqlCommand(cmdmsgforbooks, conn.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }
            conn.Close();
            return dt;

        }

        public DataTable searchBookByCategoryandAuthor(string cat, string auth)
        {
            DataTable dt = new DataTable();
            cmdmsgforbooks = cmdmsgforbooks + " WHERE Book_Cat_ID_f = " + cat + " AND Book_Auth_ID_f = " + auth + "";
            try
            {
                cmd = new SqlCommand(cmdmsgforbooks, conn.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }
            conn.Close();
            return dt;

        }

        public DataTable searchBookByTitleandCategoryandAuthor(string title, string cat, string auth)
        {
            DataTable dt = new DataTable();
            cmdmsgforbooks = cmdmsgforbooks + " WHERE Book_ID = " + title + " AND Book_Cat_ID_f = " + cat + " AND Book_Auth_ID_f = " + auth + "";
            try
            {
                cmd = new SqlCommand(cmdmsgforbooks, conn.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }
            conn.Close();
            return dt;


        }

     


        

      




        //For Inserting Books
        public string addBook(string title, string category, string author, int price, int quantity)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO tbl_Book VALUES('" + title + "'," + quantity + "," + price + "," + category + "," + author + ")", conn.Connect());
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Successfuly Inserted";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        /*
        public int addBookcategory(string cat)
        {
            int id = 0;
            try
            {
                cmd = new SqlCommand("Insert into tbl_Category VALUES('" + cat + "') Select SCOPE_IDENTITY();", conn.Connect());

                id = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();
            }
            catch (Exception ex)
            {
                string a = ex.Message;

            }

            return id;

        }
         */

        


        //For Updating Book

        public string updateBook(string ID, string title, string category, string author, int price, int quantity)
        {

            try
            {
                cmd = new SqlCommand("Update tbl_Book SET Book_Name = '" + title + "',Book_Cat_ID_f = " + category + ",Book_Auth_ID_f = " + author + ",Book_PerDayPrice=" + price + ",book_qty=" + quantity + " WHERE Book_ID = " + ID + "", conn.Connect());
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Successfuly Updated";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }


        //For Verify


        /*
        public bool verifyCategory(DataTable dt)
        {

            try
            {
                cmd = new SqlCommand("Select Count(*) from tbl_Category", conn.Connect());
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int n = dr.GetInt32(0);
                conn.Close();

                for (int i = 0; i < n; i++)
                {
                    if (dt.Rows[i]["Cat_Name"].ToString() == category)
                    {
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }

            return false;
        }
         * */


        public DataTable getBookCategory()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("Select Cat_ID,Cat_Name from tbl_Category", conn.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
            conn.Close();
            return dt;

        }

        public int getpriceperdayAndBookID(int baid, int custid, out string bookid)
        {

            try
            {
                cmd = new SqlCommand("Select Rcpt_Book_ID_f from tbl_Receipt WHERE Rcpt_BA_ID_f = " + baid + " AND Rcpt_Cust_ID_f = " + custid + "", conn.Connect());
                SqlDataReader dr1 = cmd.ExecuteReader();
                dr1.Read();
                bookid = dr1[0].ToString();

                conn.Close();


                cmd = new SqlCommand("Select Book_PerDayPrice from tbl_Book WHERE Book_ID = " + bookid + "", conn.Connect());
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int priceperday = Convert.ToInt32(dr[0]);
                conn.Close();


                return priceperday;


            }
            catch (Exception ex)
            {
                string a = ex.Message;
                bookid = "";

            }
            return 0;


        }
        public int delete(int id)
        {

            try
            {
                cmd = new SqlCommand("delete from tbl_Book where Book_ID="+id+"", conn.Connect());

                id = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();
                MessageBox.Show("Book Delete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Book issue someone.");

            }

            return id;
        }


    }
}
