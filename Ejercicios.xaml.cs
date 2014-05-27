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
using System.Collections.ObjectModel;

namespace ListasObservables
{
    public partial class MainPage : PhoneApplicationPage
    {

        public MainPage()
        {
            InitializeComponent();
            ListaNombre = new ObservableCollection<ItemModelo>();
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
            button2.IsEnabled = false;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (ListaNombre.Count == 0)
            {
                string[] arregloNombres = new string[] { "Asombro", "Enojo", "Amor", "Alegria", "Miedo", "Duda" };
                foreach (string item in arregloNombres)
                {
                    ListaNombre.Add(new ItemModelo { Nombre = item });
                }

            }
        }
        public static ObservableCollection<ItemModelo> ListaNombre { get; private set; }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ListPicker.xaml", UriKind.Relative));
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            if (tbUsuario.Text.ToString() == "Amor" || tbUsuario.Text.ToString() == "amor")
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
            NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
        }
    }
}