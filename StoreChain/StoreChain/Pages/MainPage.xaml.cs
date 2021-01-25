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

namespace StoreChain.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OwnerOpen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OwnerPage());
        }

        private void ProviderOpen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProviderPage());
        }

        private void SroreOpen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StorePage());
        }

        private void ConsignmentOpen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ConsignmentPage());
        }
    }
}
