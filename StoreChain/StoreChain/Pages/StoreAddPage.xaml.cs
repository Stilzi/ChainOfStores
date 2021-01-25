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
    public partial class StoreAddPage : Page
    {
        public StoreAddPage()
        {
            InitializeComponent();
            Ownercmb.ItemsSource = dbContext.db.Owner.Select(item => item.Name).ToList();
        }

        private void goback_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void insertbtn_Click(object sender, RoutedEventArgs e)
        {
            var insertOwner = dbContext.db.Owner.FirstOrDefault(item => item.Name == Ownercmb.Text);
            STORE insertStore = new STORE()
            {
                NAME = NameTxb.Text,
                Profile = ProfileTxb.Text,
                Phone = PhoneTxb.Text,
                Capital = Convert.ToInt32(CapitalTxb.Text),
                NumberOfRegistration = Convert.ToInt32(NumberOfRegistrationTxb.Text),
                DateOfRegistration = Convert.ToDateTime(DateOfRegistrationdp.SelectedDate),
                Contribution = Convert.ToInt32(ContributionTxb.Text),
                OwnerID = insertOwner.ID
            };
            dbContext.db.STORE.Add(insertStore);
            dbContext.db.SaveChanges();
            MessageBox.Show("Добавлено", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
