using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DeliveryNoteCollection
    {
        public DeliveryNote ActualDeliveryNote { get; set; }
        public DeliveryNoteCollection()
        {
            
        }

        public DeliveryNote CreateDeliveryNote()
        {
            ActualDeliveryNote=new DeliveryNote(DateTime.Now);
            return ActualDeliveryNote;

        }

    }
}
