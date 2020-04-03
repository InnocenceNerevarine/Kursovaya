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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var currentUser = AppData.context.User.ToList().
                Where(p => p.Login == TextBoxLogin.Text && p.Password == PasswordBox.Password).FirstOrDefault();
            if (currentUser != null)
            {
                switch (currentUser.ID_Role)
                {
                    case 1:
                        AppData.MenuFrame.Navigate(new Admin.MenuAdmin());
                        AppData.MainFrame.Navigate(new admin.CatalogAdmin());
                        break;
                    case 2:
                        AppData.MenuFrame.Navigate(new bruger.UserMenu());
                        AppData.MainFrame.Navigate(new bruger.Catalog());
                        break;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль \n  Повторите попытку", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
