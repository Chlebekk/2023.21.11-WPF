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
using System.Windows.Shapes;

namespace _2023._21._11
{
    /// <summary>
    /// Logika interakcji dla klasy Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String wpisanyTXT = awooga.Text;
            MessageBox.Show("tekst:" + wpisanyTXT, "okno informacyjne",MessageBoxButton.OK,MessageBoxImage.Exclamation);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String wpisanyTXT = rozmiarSlider.Value.ToString();
            MessageBox.Show(wpisanyTXT,"mario gonna steal your liver", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
