using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class FacadeController
    {
        public CustomerCollection MyCustomerCollection;
        public DeliveryNoteCollection MyDeliveryNoteCollection;
        public BeerCollection MyBeerCollection;
        public DatabaseController MyDatabaseController;
        public DeliveryNote ActualDeliveryNote { get; set; }


        public FacadeController()
        {
            MyDatabaseController = new DatabaseController();
            MyBeerCollection=new BeerCollection(MyDatabaseController.myBeers);
            MyCustomerCollection=new CustomerCollection(MyDatabaseController.MyCustomers);
            MyDeliveryNoteCollection=new DeliveryNoteCollection();

        }

        public void BLaBLaBLa()
        {
<<<<<<< HEAD
<<<<<<< HEAD
            int testint = 0;
=======
            List<string> customerList = new List<string>();
            foreach (Customer c in MyCustomerCollection.MyCustomers)
            {
                customerList.Add(c.Name);
            }
            return customerList;
>>>>>>> 03ae7bfbd806332d276699bb157cbbbb0d63bff9
=======
            
>>>>>>> parent of 03ae7bf... changed blablabla
            //hello
        }

        public List<string> GetCustomers()
        {
            List<string> customerList = new List<string>();
            foreach (Customer c in MyCustomerCollection.MyCustomers)
            {
                customerList.Add(c.Name);
            }
            return customerList;
        }
        public List<string> GetBeers()
        {
            List<string> beerList = new List<string>();
            foreach (Beer b in MyBeerCollection.MyBeers)
            {
                beerList.Add(b.Name);
            }
            return beerList;
        }

       

        public void CreateDeliveryNote()  
        {
           ActualDeliveryNote = MyDeliveryNoteCollection.CreateDeliveryNote();            
        }
        
        public int SaveDeliveryNote()
        {
            DeliveryNote dn = new DeliveryNote(DateTime.Now);
            
            DatabaseController db = new DatabaseController();
            db.SaveDeliveryNote();
           
            return 1;
        }
    }
}
