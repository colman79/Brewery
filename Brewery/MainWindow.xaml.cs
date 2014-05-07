using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Controller;

namespace Brewery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FacadeController MyFacadeController;
        public MainWindow()
        {
            InitializeComponent();
            MyFacadeController=new FacadeController();
            SetBeerList();
            SetCustomerList();
            MyFacadeController.CreateDeliveryNote();
        }

        public void SetCustomerList()
        {
            lbBoxCustomer.Items.Clear();
            foreach (string s in MyFacadeController.GetCustomers())
            {
                lbBoxCustomer.Items.Add(s);
            }
        }
        public void SetBeerList()
        {
            LbBeer.Items.Clear();
            foreach (string s in MyFacadeController.GetBeers())
            {
                LbBeer.Items.Add(s);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
