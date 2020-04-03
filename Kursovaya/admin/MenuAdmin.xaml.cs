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

namespace Kursovaya.Admin
{
    /// <summary>
    /// Логика взаимодействия для MenuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin : Page
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.MenuFrame.GoBack();
            AppData.MainFrame.Navigate(new Info());
        }

        private void Addadmin_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new admin.AddAdmin());
        }
    }
}
