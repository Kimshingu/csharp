﻿using System.ComponentModel;
using System.Windows;

namespace Task2_LoginWindow
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show(VMMainWindow.LastName + ":" + VMMainWindow.FirstName);
        }
    }
}
