﻿using System;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppData.MenuFrame = MenuFrame;
            AppData.MenuFrame.Navigate(new Authorization());
            AppData.MainFrame = MainFrame;
            AppData.MainFrame.Navigate(new Info());

        }

        private void MenuFrame_ContentRendered(object sender, EventArgs e)
        {

        }

        private void MenuFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {

        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
