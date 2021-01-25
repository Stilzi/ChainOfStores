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
    public partial class OwnerPage : Page
    {
        public OwnerPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ownerdg.ItemsSource = dbContext.db.Owner.ToList();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            dbContext.db.SaveChanges();
        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            Owner deleteOwner = (Owner)ownerdg.SelectedItem;
            dbContext.db.Owner.Remove(deleteOwner);
            dbContext.db.SaveChanges();
            ownerdg.ItemsSource = dbContext.db.Owner.ToList();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            ownerdg.ItemsSource = dbContext.db.Owner.Where(item => item.Name.Contains(search.Text) && item.Phone.Contains(search.Text)).ToList();
        }

        private void insertbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OwnerAddPage());
        }
    }
}
