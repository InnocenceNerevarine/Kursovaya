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

namespace Kursovaya
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

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if(Login.Text == "" || Password.Text == "" || PhoneNumber.Text == "" || Name.Text == "" || LastName.Text == "" )
            {
                //       System.Windows.MessageBox.Show("Введены не все данныe \n  Повторите попытку", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                popup.IsOpen = true;
                if (LastName.Text == "") { BorderLastName.BorderBrush = Brushes.Red; }
                if (Login.Text == "") { BorderLogin.BorderBrush = Brushes.Red; }
                if (Password.Text == "") { BorderPassword.BorderBrush = Brushes.Red; }
                if (PhoneNumber.Text == "") { BorderPhoneNumber.BorderBrush = Brushes.Red; }
                if (Name.Text == "") { BorderName.BorderBrush = Brushes.Red; }

            }

            else
            {
                AppData.context.User.Add(new User
                {
                    Login = Login.Text,
                    Password = Password.Text,
                    Phone_Number = PhoneNumber.Text,
                    Name = Name.Text,
                    Surname = LastName.Text,
                    ID_Role = 2
                });
                AppData.context.SaveChanges();
                System.Windows.MessageBox.Show("Вы создали аккаунт", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                if (MessageBoxButton.OK == 0)
                {
                    AppData.MainFrame.Navigate(new Info());
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new Info());
        }
    }
}
