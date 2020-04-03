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
    /// Логика взаимодействия для InfoProduct.xaml
    /// </summary>
    public partial class InfoProduct : Page
    {
        private int _numValue = 0;

        public int NumValue
        {
            get { return _numValue; }
            set
            {
                _numValue = value;
                txtNum.Text = value.ToString();
            }
        }
        public byte[] _photo;
        public InfoProduct(int product)
        {
            InitializeComponent();
            txtNum.Text = _numValue.ToString();
            Product product1 = AppData.context.Product.FirstOrDefault(p => p.ID_Product == product);
            NameProduct.Text = product1.Name_Product;
            prise.Text = Convert.ToString(product1.Price);
            Contrymonufakture.Text = product1.Contry_Manufacture;
            category.Text = product1.Category_Product.Category_Name;
            if(product1.Id_Warning == 1 )
            {
                Warning.Text = "Да";
            }
            else
            {
                Warning.Text = "Нет";
            }
            TextBoxComposition.Text = product1.Composition;
            TextBoxContraindication.Text = product1.Contraindication;
            TextBoxDescripton.Text = product1.Sescription;
            TextBoxIndication.Text = product1.Indicatioin;
            TextBoxMethod.Text = product1.Method_of_application;

            _photo = product1.Photo;
            Image.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(product1.Photo);
          

        }

        private void Pay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            NumValue++;
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            NumValue--;
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum == null)
            {
                return;
            }

            if (!int.TryParse(txtNum.Text, out _numValue))
                txtNum.Text = _numValue.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.GoBack();
        }
    }
}
