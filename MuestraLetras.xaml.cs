using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ListasObservables.ViewModel;

namespace ListasObservables
{
    public partial class MuestraLetras : PhoneApplicationPage
    {

        protected LasLetras ViewModel;

        public MuestraLetras()
        {
            InitializeComponent();
            ViewModel = new LasLetras();
            this.DataContext = ViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sonidos.CurrentState != System.Windows.Media.MediaElementState.Playing)
                sonidos.Play();
        }


        private void cmdSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (!ViewModel.EsUltima)
            {
                ViewModel.SiguientePregunta();
            }
            else
            {
                MessageBox.Show("Has terminado!", "Felicidades!", MessageBoxButton.OK);
                NavigationService.Navigate(new Uri("/Portada.xaml", UriKind.Relative));
            }
        }

        private void cmdAntes_Click(object sender, RoutedEventArgs e)
        {
            if (!ViewModel.EsPrimera)
            {
                ViewModel.AnteriorPregunta();
                sonidos.Play();
            }
        }
    }
}