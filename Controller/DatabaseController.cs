using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient;
using Model;


namespace Controller
{
    public class DatabaseController
    {
        const string DbConnection = @"Data Source=ealdb1.eal.local;User ID=ejl22_usr;Password=Baz1nga22"; // don`t forget @ before the connection!!! change this to ur own db address

        SqlConnection con;
        SqlCommand cmd;
        public List<Beer> myBeers =new List<Beer>(); 
        public List<Customer> MyCustomers =new List<Customer>();

        public DatabaseController()
        {
            MyCustomers.Add(new Customer("Bob","12 victoria rd","Torquay","5260"));
            MyCustomers.Add(new Customer("John", "1 Kings rd", "Torquay", "5260"));
            MyCustomers.Add(new Customer("Ian", "112 Market st", "exeter", "6260"));
            MyCustomers.Add(new Customer("jack", "32 queens rd", "Torquay", "5260"));
            myBeers.Add(new Beer("APA"));
            myBeers.Add(new Beer("EDS"));
            myBeers.Add(new Beer("DCB"));
            myBeers.Add(new Beer("IPA"));
            
            /*
                con = new SqlConnection(DbConnection);
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure; 
            */
        }

        public int SaveDeliveryNote()
        {
        
            SqlDataReader rdr  = null;
            using (SqlConnection con = new SqlConnection(DbConnection))
            {            
                SqlCommand cmd = new SqlCommand(
                    "SP_create_DeliveryNote", con);

                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add(new SqlParameter("@DeliveryNoteId", SqlDbType.Int)).Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(new SqlParameter("@date", deliveryNote.DateOfCreation));
                //cmd.Parameters.Add(new SqlParameter("@CustomerID", deliveryNote.Customer.CustomerID));

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@DeliveryNoteId", SqlDbType.Int)).Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@date", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@CustomerID", 1));

                int result = cmd.ExecuteNonQuery();

                int DNID = (int)cmd.Parameters["@deliverynoteId"].Value;

                return 1;
             }

    
        }

    }
}
