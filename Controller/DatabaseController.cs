using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient;

namespace Controller
{
    public class DatabaseController
    {
        const string DbConnection = @"Data Source=ealdb1.eal.local;User ID=ejl22_usr;Password=Baz1nga22"; // don`t forget @ before the connection!!! change this to ur own db address

        SqlConnection con;
        SqlCommand cmd;

        public DatabaseController()
        {
            con = new SqlConnection(DbConnection);

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure; 

        }

    }
}
