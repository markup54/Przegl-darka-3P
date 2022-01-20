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

namespace Przeglądarka_3P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RamkaOn_Click(object sender, RoutedEventArgs e)
        {
            if (brdRamka != null)
                brdRamka.BorderThickness = new Thickness(3);
        }

        private void RamkaOff_Click(object sender, RoutedEventArgs e)
        {
            if(brdRamka != null)
                brdRamka.BorderThickness = new Thickness(0);
        }

        private void OProgramie_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Prościutka przeglądarka zrobiona z klasą 3P w styczniu 2022");
        }

        private void wejdz_Click(object sender, RoutedEventArgs e)
        {
            wbPrzegladarka.Navigate(txtAdres.Text);
        }

        private void wstecz_Clisk(object sender, RoutedEventArgs e)
        {
            if(wbPrzegladarka.CanGoBack)
                wbPrzegladarka.GoBack();
        }

        private void dalej_Click(object sender, RoutedEventArgs e)
        {
            if(wbPrzegladarka.CanGoForward)
                wbPrzegladarka.GoForward();
        }

        private void adres_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                wbPrzegladarka.Navigate(txtAdres.Text);
        }
    }
}
