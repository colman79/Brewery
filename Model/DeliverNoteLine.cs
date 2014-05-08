using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DeliverNoteLine
    {
        public int Quantity { get; set; }
        public Beer MyBeer { get; set; }

        public DeliverNoteLine(int quantity)
        {
            Quantity = quantity;

        }

    }
}
