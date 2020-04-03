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

namespace Kursovaya.bruger
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        public Catalog()
        {
            InitializeComponent();
            UpdateProduct();

            var listcategory = AppData.context.Category_Product.ToList();
            listcategory.Insert(0, new Category_Product()
            {
                ID_Category = -1,
                Category_Name = "Все категории"

            });
            ComBoxSearch.DisplayMemberPath = "Category_Name";
            ComBoxSearch.ItemsSource = listcategory;

        }

        public void UpdateProduct()
        {
            LVProduct.ItemsSource = AppData.context.Product.ToList();
        }
        public void UpdateSearch()
        {
            var listProduct = AppData.context.Product.ToList();

            if(ComBoxSearch.SelectedIndex>0)
            {
                listProduct = listProduct.Where(p => p.Category_Product.Category_Name == (ComBoxSearch.SelectedItem as Category_Product).Category_Name).ToList();
            }

            string keyWord = textBoxSearch.Text.ToLower();
            listProduct = listProduct.Where(p => p.Name_Product.ToLower().Contains(keyWord)).ToList();
            LVProduct.ItemsSource = listProduct;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var currentProduct = (sender as Button).DataContext as Product;
            var product = currentProduct.ID_Product;
            AppData.MainFrame.Navigate(new InfoProduct(product));
        }

        private void LVProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateSearch();
        }

        private void ComBoxSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSearch();
        }

        private void Trigger_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
