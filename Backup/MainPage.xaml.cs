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
        public Entrada()
        {
            InitializeComponent();
            Siguiente.IsEnabled = false;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String s1 = this.txt.Text;
            MessageBox.Show("Hola!  " + s1);
            Siguiente.IsEnabled = true;
        }

        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Portada.xaml", UriKind.Relative));
        }
    }
}