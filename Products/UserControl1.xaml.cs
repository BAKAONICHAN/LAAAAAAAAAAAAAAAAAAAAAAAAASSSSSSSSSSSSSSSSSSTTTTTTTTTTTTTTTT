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

namespace Products
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public List<int> products;
        public int ccount;
        public int count {
            get
            {
                return ccount;
            }
            set
            {
                ccount = value;
                CountOfpProducts.Text = count.ToString();
                
            }
        }

        public UserControl1()
        {
            InitializeComponent();
            CountOfpProducts.Text = count.ToString();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            count++;
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            count--;
        }
    }
}
