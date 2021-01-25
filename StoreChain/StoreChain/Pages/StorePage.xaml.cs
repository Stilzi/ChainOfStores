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
    /// <summary>
    /// Логика взаимодействия для StorePage.xaml
    /// </summary>
    public partial class StorePage : Page
    {
        public StorePage()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            storedg.ItemsSource = dbContext.db.STORE.Where(item => item.NAME.Contains(search.Text) && item.Profile.Contains(search.Text) && item.Phone.Contains(search.Text) && item.Owner.Name.Contains(search.Text) && item.Owner.Phone.Contains(search.Text)).ToList();
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            dbContext.db.SaveChanges();
        }

        private void insertbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StoreAddPage());
        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            STORE deleteStore = (STORE)storedg.SelectedItem;
            dbContext.db.STORE.Remove(deleteStore);
            dbContext.db.SaveChanges();
            storedg.ItemsSource = dbContext.db.STORE.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            storedg.ItemsSource = dbContext.db.STORE.ToList();
        }
    }
}
