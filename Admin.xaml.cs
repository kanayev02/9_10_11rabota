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

namespace _91011rabota
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Vihod_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new Vhod());
        }

        private void Polz_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new Polzovateli());
        }

        private void Stud_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.mainFrame.Navigate(new Studenti());
        }
    }
}
