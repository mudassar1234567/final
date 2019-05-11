using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Daud_factory
{
    class salesdb
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;

        public salesdb()
        {
            con = new SqlConnection("Data Source=DESKTOP-GB0LHG2\\MSSQLSERVER01;Database=daudFactoryDB;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = con;
            da = new SqlDataAdapter();
            dt = new DataTable();
            con.Open();
        }
        public void Sqlcommand(string queryText)
        {
            cmd = new SqlCommand(queryText, con);
        }
        public DataTable QueryEx()
        {
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void NonQueryEx()
        {
            cmd.ExecuteNonQuery();
        }
        public DataTable selectall()
        {
            da = new SqlDataAdapter("Select * from sales", con);
            da.Fill(dt);
            return dt;
        }
        public void get(int id)
        {
            cmd.CommandText = "Select id from sales where id=" + id;
            da.Fill(dt);
        }
        public void update(int id, string name, int quantity, int weight)
        {
            cmd.Connection = con;
            cmd.CommandText = "UPDATE sales SET name =" + name + ", quantity=" + quantity + ",weight=" + weight + "WHERE id=" + id;
            da.Fill(dt);
        }
        public void delete(int id)
        {
            cmd.Connection = con;
            cmd.CommandText = "delete from sales where id='" + id + "';";
            da.Fill(dt);

        }
    }
}
