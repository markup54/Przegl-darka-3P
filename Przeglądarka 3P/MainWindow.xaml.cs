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
    }
}
