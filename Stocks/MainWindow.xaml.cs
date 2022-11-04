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

namespace Stocks
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

        private void StaffJornal_Click(object sender, RoutedEventArgs e)
        {
            new Stocks.Windows.StaffJournal().Show();
        }

        private void InventoryTypeJournal_Click(object sender, RoutedEventArgs e)
        {
            new Stocks.Windows.InventoryTypeJournal().Show();
        }
    }
}
