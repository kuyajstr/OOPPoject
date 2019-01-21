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
        //List<string> names = new List<string>();

        //public MainWindow m1 = new MainWindow();
        public AddTransaction t1 = new AddTransaction();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            t1.Main = this;
            t1.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Jewelry.Show();
            //this.Close();
        }
    }
}
