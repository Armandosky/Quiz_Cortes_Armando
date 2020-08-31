using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Xdxd
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string productName = txtProductName.Text;
            string category = lblCategory.Content.ToString();
            string trademark = comboxtm.Text;
            string ipcode = lblIpcode.Content.ToString();
            string price = slprice.Value.ToString();

            txtResults.Text = productName + "\n" + category + "\n" + trademark + "\n" + ipcode + "\n" + price;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if(rb.IsChecked.Value)
            {
                lblCategory.Content = rb.Content.ToString();
            }
        }

        private void btnOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Login());
        }

        private void comboxtm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chb = sender as CheckBox;
            if (chb.IsChecked.Value)
            {
                lblIpcode.Content = chb.Content.ToString();
            }
        }

        private void slprice_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblPrice.Content = "Price = $" + slprice.Value.ToString();
        }
    }
}
