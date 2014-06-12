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
    public partial class Entrada : PhoneApplicationPage
    {
        bool NombreListo = false;

        public Entrada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NombreRecibido();
        }

        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
            NavigateNext();
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            //if enter was pressed
            if (e.Key == Key.Enter)
                NombreRecibido();
        }

        private void NombreRecibido()
        {
            if (!NombreListo)
            {
                if (!string.IsNullOrWhiteSpace(this.txt.Text))
                {
                    MessageBox.Show("Hola!  " + this.txt.Text);
                    Siguiente.IsEnabled = true;
                    //Siguiente.Focus();
                    NombreListo = true;
                    NavigateNext();
                }
                else
                {
                    MessageBox.Show("Necesita introducir su nombre", "Error!", MessageBoxButton.OK);
                    Siguiente.IsEnabled = false;
                }
            }
        }

        private void NavigateNext()
        {
            NavigationService.Navigate(new Uri("/Portada.xaml", UriKind.Relative));
        }

        private void txt_LostFocus(object sender, RoutedEventArgs e)
        {
            NombreRecibido();
        }
    }
}