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
using System.Windows.Shapes;

namespace OOP_Project
{
    /// <summary>
    /// Interaction logic for AddTransaction.xaml
    /// </summary>
    public partial class AddTransaction : Window
    {
        public MainWindow Main;
        //AddTransaction t2;

        public AddTransaction()
        {
            InitializeComponent();
        }

        private void cmbCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            //AddCustomer c1;
            //c1.Main = this;

        }

        private void btnTransaction_Click(object sender, RoutedEventArgs e)
        {
            Main.Show();
            this.Close();
        }

        private void Quantity_TextChanged(object sender, TextChangedEventArgs e)
        {



        }

        private void Price_TextChanged(object sender, TextChangedEventArgs e)
        {
            //pricse
        }
    }
}
