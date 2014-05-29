﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ListasObservables
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
            button2.IsEnabled = false;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            if (tbUsuario.Text.ToString() == "Enojo" || tbUsuario.Text.ToString() == "enojo")
            {
                tbMensaje.Text = "Correcto";
                button2.IsEnabled = true;
            }
            else
            {
                tbMensaje.Text = "Incorrecto";
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }
        }
    }
