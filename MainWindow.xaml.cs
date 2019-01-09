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

namespace OOP_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public Person Customer;
        TransactionWindow transwin = new TransactionWindow();

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string FirstName = this.txtFirstName.Text;
            string MiddleName = this.txtMiddletName.Text; ;
            string LastName = this.txtLasttName.Text; ;
            string BirthDate = this.dpBirthdate.Text; ;
            string Address = this.txtAddress.Text; ;
            transwin.Customer = new Person(FirstName, LastName, MiddleName);

            transwin.Jewelry = new Product();
            transwin.Jewelry.Name = this.cmdJewelry.Text;


            transwin.Show();

        }

    }
}
