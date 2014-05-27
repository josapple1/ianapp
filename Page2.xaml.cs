using System;
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
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
            button2.IsEnabled = false;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            if (tbUsuario.Text.ToString() == "Enojo")
            {
                tbMensaje.Text = "Correcto";
            }
            else
            {
                tbMensaje.Text = "Incorrecto";
                button2.IsEnabled = true;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page3.xaml", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListPicker.xaml", UriKind.Relative));
        }
    }
}