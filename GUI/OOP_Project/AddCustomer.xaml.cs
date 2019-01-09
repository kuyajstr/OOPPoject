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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public MainWindow main;


        public AddCustomer()
        {
            InitializeComponent();
        }

        private void txtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddTransaction t2 = new AddTransaction();
            t2.cmbCustomer.Items.Add(txtFirstName);
            //main.Name.Add

            ////string FirstName = this.txtFirstName.Text;
            ////string MiddleName = this.txtMiddleName.Text;
            ////string LastName = this.txtLastName.Text;

            ////Person Customer = new Person(FirstName, LastName, MiddleName);

            ////Customer.BirthDate = this.dpBirthDate.Text;
            ////Customer.Address = this.txtAddress.Text;

            //Data Customer = new Data();

            
            AddTransaction AddCustomer = new AddTransaction();
            //AddCustomer.cmbCustomer.Items.Add(Customer.GetCustomer());


            AddCustomer.Show();
            this.Close();

        }   

        private void txtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
