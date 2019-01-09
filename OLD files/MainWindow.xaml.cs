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

    public partial class MainWindow : Window
    {
        public Product Customer = new Product();
        


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            AddTransaction AddTrans = new AddTransaction();

            AddTrans.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();

            AddJewelry Jewelry = new AddJewelry();

            Jewelry.Show();
        }
    }
}
