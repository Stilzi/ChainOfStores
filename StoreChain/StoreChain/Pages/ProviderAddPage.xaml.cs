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
    /// Логика взаимодействия для ProviderAddPage.xaml
    /// </summary>
    public partial class ProviderAddPage : Page
    {
        public ProviderAddPage()
        {
            InitializeComponent();
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void insertbtn_Click(object sender, RoutedEventArgs e)
        {
            Provider insertProvider = new Provider()
            {
                Name = NameTxb.Text,
                Address = AddressTxb.Text,
                Phone = PhoneTxb.Text
            };
            dbContext.db.Provider.Add(insertProvider);
            dbContext.db.SaveChanges();
            MessageBox.Show("Добавлено", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
