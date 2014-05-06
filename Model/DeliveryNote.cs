using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DeliveryNote
    {
        public DateTime DateOfCreation { get; set; }
        public List<DeliverNoteLine> MyDeliverNoteLines { get; set; }

        public DeliveryNote(DateTime dateofCreation)
        {
            DateOfCreation = dateofCreation;
        }

    }
}
