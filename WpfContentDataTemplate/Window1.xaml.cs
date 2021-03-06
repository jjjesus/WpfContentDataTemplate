﻿using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            ViewModel = new DeviceDetailsViewModel();
            DataContext = ViewModel;
            InitializeComponent();
        }
        public DeviceDetailsViewModel ViewModel { get; set; }

        private void CardClick(object sender, RoutedEventArgs e)
        {
            ViewModel.SelectedViewModel = new CardViewModel("Card-2");
        }

        private void RackClick(object sender, RoutedEventArgs e)
        {
            ViewModel.SelectedViewModel = new RackViewModel("Rack-2");
        }

        private void BoxClick(object sender, RoutedEventArgs e)
        {
            ViewModel.SelectedViewModel = new BoxViewModel("Box-2");
        }
    }
}
