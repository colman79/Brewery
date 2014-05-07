using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        
        public List<DeliveryNote> MyDeliveryNotes { get; set; }

        public Customer(string name,string street,string town,string postCode)
        {
            Name = name;
            Street = street;
            Town = town;
            PostCode = postCode;
        }
    }
}
