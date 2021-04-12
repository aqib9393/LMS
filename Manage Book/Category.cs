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
    class Category
    {
        SqlCommand cmd = null;
        Connection conn = new Connection();
        string category;

        public Category(string cat)
        {
            category = cat;
        }

        public Category() { }

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
    }
}
