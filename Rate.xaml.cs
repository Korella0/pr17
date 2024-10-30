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

namespace pr17
{
    /// <summary>
    /// Логика взаимодействия для Rate.xaml
    /// </summary>
    public partial class Rate : UserControl
    {
        public Rate()
        {
            InitializeComponent();
        }

        private void Rad1_Checked(object sender, RoutedEventArgs e)
        {
            test.Text = "1 звезда";
        }

        private void Rad2_Checked(object sender, RoutedEventArgs e)
        {

            if (Rad2.IsChecked == true)
            {
                Rad1.IsChecked = true;
            }

            test.Text = "2 звезды";

        }

        private void Rad3_Checked(object sender, RoutedEventArgs e)
        {

            if (Rad3.IsChecked == true)
            {
                Rad2.IsChecked = true;
                Rad1.IsChecked = true;
            }

            test.Text = "3 звезды";

        }

        private void Rad4_Checked(object sender, RoutedEventArgs e)
        {

            if (Rad4.IsChecked == true)
            {
                Rad2.IsChecked = true;
                Rad3.IsChecked = true;
                Rad1.IsChecked = true;
            }

            test.Text = "4 звезды";

        }

        private void Rad5_Checked(object sender, RoutedEventArgs e)
        {

            if (Rad5.IsChecked == true)
            {
                Rad2.IsChecked = true;
                Rad3.IsChecked = true;
                Rad4.IsChecked = true;
                Rad1.IsChecked = true;
            }

            test.Text = "5 звезд";

        }

        private void Baton_Click(object sender, RoutedEventArgs e)
        {
            Rad2.IsChecked = false;
            Rad3.IsChecked = false;
            Rad4.IsChecked = false;
            Rad1.IsChecked = false;
            Rad5.IsChecked = false;

            test.Text = "";
        }
    }
}
