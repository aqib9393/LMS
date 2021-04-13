using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem.Suggestion
{
    
    class Suggest
    {

        
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=LibraryManagementSystem;Integrated Security=True");
       
        public void ADU(string query, DataGridView grib)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            disp(grib);
            
        }
       
        public void search(string query, DataGridView grid)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grid.DataSource = dt;
            con.Close();
        }
        public void disp(DataGridView grid)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from sugg";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            grid.DataSource = dt;
            con.Close();    
        }
    }
}
