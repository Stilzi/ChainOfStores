using StoreChain.Classes;
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
    /// Логика взаимодействия для AvtorizationPage.xaml
    /// </summary>
    public partial class AvtorizationPage : Page
    {
        public AvtorizationPage()
        {
            InitializeComponent();
        }

        private void Avtorization_Click(object sender, RoutedEventArgs e)
        {
            var avtorization = dbContext.db.Account.FirstOrDefault(item => item.Login == txbLogin.Text && item.Password == txbPassword.Password);
            if (avtorization == null)
            {
                MessageBox.Show("Не удалось войти, возможно вы указали неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                NavigationService.Navigate(new MainPage());
            }
        }
    }
}
