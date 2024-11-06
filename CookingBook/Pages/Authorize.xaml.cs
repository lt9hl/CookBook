using CookingBook.AppData;
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

namespace CookingBook.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorize.xaml
    /// </summary>
    public partial class Authorize : Page
    {
        public Authorize()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = AppConnect.modelOdb.Authors.FirstOrDefault(x => x.Login == TextLogin.Text && x.Password == TextPassword.Password);
                    if( userObj == null)
                    {
                    MessageBox.Show("Пользователь не найден!","Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                else
                {
                    MessageBox.Show($"Здравствуйте, {userObj.AuthorName}", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new Pages.PageRecipe());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message.ToString() + "Критическая работа приложения!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SungUpButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.Registration());
        }
    }
}
