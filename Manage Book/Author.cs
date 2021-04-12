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
    class Author
    {
        SqlCommand cmd = null;
        Connection conn = new Connection();
        string author;
        public Author(string auth)
        {
            author = auth;
        }

        public Author() { }
        public bool verifyAuthor(DataTable dt)
        {

            try
            {
                cmd = new SqlCommand("Select Count(*) from tbl_Author", conn.Connect());
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int n = dr.GetInt32(0);
                conn.Close();

                for (int i = 0; i < n; i++)
                {
                    if (dt.Rows[i]["Auth_Name"].ToString() == author)
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

        public int addBookauthor(string auth)
        {
            int id = 0;
            try
            {
                cmd = new SqlCommand("Insert into tbl_Author VALUES('" + auth + "') Select SCOPE_IDENTITY();", conn.Connect());

                id = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();
            }
            catch (Exception ex)
            {
                string a = ex.Message;

            }

            return id;

        }


        public void getAuthorAndCategory(out DataTable dt1, out DataTable dt2)
        {
            dt1 = new DataTable();
            dt2 = new DataTable();

            try
            {


                cmd = new SqlCommand("Select Cat_ID,Cat_Name from tbl_Category", conn.Connect());
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da1.Fill(dt1);
                conn.Close();

                cmd = new SqlCommand("Select Auth_ID,Auth_Name from tbl_Author", conn.Connect());
                SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                da2.Fill(dt2);


            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            conn.Close();


        }
    }
}
