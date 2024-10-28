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
using CookingBook.AppData;

namespace CookingBook.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.AppFrame.frMain.GoBack();
        }

        private void RegRepeatPassBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (RegPassBox.Password != RegRepeatPassBox.Password)
            {
                RegButt.IsEnabled = true;

            }
            else
            {
                RegButt.IsEnabled = true;
                
            }
        }

        private void RegButt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AppConnect.modelOdb.Authors.Count(x => x.Login == LoginBox.Text) > 0)
                {
                    MessageBox.Show("Пользователь с таким логином есть.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                if (String.IsNullOrEmpty(LoginBox.Text) || String.IsNullOrEmpty(UserBox.Text) || String.IsNullOrWhiteSpace(RegPassBox.Password))
                {
                    MessageBox.Show("Не заполнены поля.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                }
                Authors userObj = new Authors()
                {
                    Login = LoginBox.Text,
                    AuthorName = UserBox.Text,
                    Password = RegPassBox.Password,
                    
                };
                AppConnect.modelOdb.Authors.Add(userObj);
                AppConnect.modelOdb.SaveChanges();
                MessageBox.Show("Данные успешно добавленыЙ", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                AppData.AppFrame.frMain.GoBack();
            }
            
            catch {
                MessageBox.Show("Ошибка при добавлении данных!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
