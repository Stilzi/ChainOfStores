using StoreChain.Classes;
using StoreChain.Model;
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
    public partial class ProviderPage : Page
    {
        public ProviderPage()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void insertbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProviderAddPage());
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            dbContext.db.SaveChanges();
        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            Provider deleteProvider = (Provider)providerdg.SelectedItem;
            dbContext.db.Provider.Remove(deleteProvider);
            dbContext.db.SaveChanges();
            providerdg.ItemsSource = dbContext.db.Provider.ToList();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            providerdg.ItemsSource = dbContext.db.Provider.Where(item => item.Name.Contains(search.Text) && item.Address.Contains(search.Text) && item.Phone.Contains(search.Text)).ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            providerdg.ItemsSource = dbContext.db.Provider.ToList();
        }
    }
}
