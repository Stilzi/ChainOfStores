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
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Avtorization_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AvtorizationPage());
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            Account insertAccount = new Account() 
            {
                Login = txbLogin.Text,
                Password = txbPassword.Password
            };
            dbContext.db.Account.Add(insertAccount);
            dbContext.db.SaveChanges();
            MessageBox.Show("Аккаунт зарегестрирован", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
