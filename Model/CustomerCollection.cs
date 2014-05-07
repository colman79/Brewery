using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CustomerCollection
    {
        public List<Customer> MyCustomers { get; set; } 

        public CustomerCollection (List<Customer> myCustomers )
        {
            MyCustomers=new List<Customer>(myCustomers);
        }


    }
}