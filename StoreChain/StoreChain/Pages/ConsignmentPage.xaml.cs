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
    /// Логика взаимодействия для ConsignmentPage.xaml
    /// </summary>
    public partial class ConsignmentPage : Page
    {
        public ConsignmentPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            consignmentdg.ItemsSource = dbContext.db.Consignment.ToList();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            Consignment insertConsignment = (Consignment)consignmentdg.SelectedItem;
            dbContext.db.Consignment.Remove(insertConsignment);
            dbContext.db.SaveChanges();
            consignmentdg.ItemsSource = dbContext.db.Consignment.ToList();
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            dbContext.db.SaveChanges();
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            consignmentdg.ItemsSource = dbContext.db.Consignment.Where(item => item.Provider.Name.Contains(search.Text) && item.STORE.NAME.Contains(search.Text));
        }

        private void insertbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ConsignmentAddPage());
        }
    }
}
