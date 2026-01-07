using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{

    public class DbCon
    {
        private SqlConnection Con;
        public DbCon()
        {
            Con = new SqlConnection("Data Source=Anum;Initial Catalog=Userss;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }

        public bool UDI(String Qry)
        {
            Con.Open();
              SqlCommand cmd = new SqlCommand(Qry, Con);
              bool result = cmd.ExecuteNonQuery() > 0;
            Con.Close();
            return result;
        }

        public DataTable Search(string Qry)
        {
            Con.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(Qry, Con);
            DataTable Dt = new DataTable();
            SDA.Fill(Dt);
            Con.Close();
            return Dt;
        }
       
    }
}
