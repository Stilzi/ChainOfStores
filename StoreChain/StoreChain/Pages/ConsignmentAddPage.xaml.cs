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
    /// Логика взаимодействия для ConsignmentAddPage.xaml
    /// </summary>
    public partial class ConsignmentAddPage : Page
    {
        public ConsignmentAddPage()
        {
            InitializeComponent();
            Storecmb.ItemsSource = dbContext.db.STORE.Select(item => item.NAME).ToList();
            ProviderCmb.ItemsSource = dbContext.db.Provider.Select(item => item.Name).ToList();
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void insertbtn_Click(object sender, RoutedEventArgs e)
        {
            var insertStore = dbContext.db.STORE.FirstOrDefault(item => item.NAME == Storecmb.Text);
            var insertProvider = dbContext.db.Provider.FirstOrDefault(item => item.Name == ProviderCmb.Text);
            Consignment insertConsignment = new Consignment()
            {
                ProviderID = insertProvider.ID,
                StoreID = insertStore.ID,
                Volume = Convert.ToInt32(VolumeTxb.Text)
            };
            dbContext.db.Consignment.Add(insertConsignment);
            dbContext.db.SaveChanges();
            MessageBox.Show("Добавлено", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
