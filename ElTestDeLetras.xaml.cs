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
    public partial class ElTestDeLetras : PhoneApplicationPage
    {
        protected TestLetras ViewModel;
        public ElTestDeLetras()
        {
            InitializeComponent();
            ViewModel = new TestLetras();
            this.DataContext = ViewModel;
            this.cmdSiguiente.IsEnabled = false;
            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            
        }

        private void cmdSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (!ViewModel.EsUltima)
            {
                ViewModel.SiguientePregunta();
                this.cmdSiguiente.IsEnabled = false;
                this.tbMensaje.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Has terminado!", "Felicidades!", MessageBoxButton.OK);
                NavigationService.Navigate(new Uri("/Portada.xaml", UriKind.Relative));
            }
        }

        private void TextBlock_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var tb = sender as TextBlock;
            if (ViewModel.RespuestaCorrecta(tb.Text))
            {
                this.tbMensaje.Text = "Correcto!";
                this.cmdSiguiente.IsEnabled = true;
                //if (correcto.CurrentState != System.Windows.Media.MediaElementState.Playing)
                //    correcto.Play();

            }
            else
            {
                this.cmdSiguiente.IsEnabled = false;
                //if (error.CurrentState != System.Windows.Media.MediaElementState.Playing)
                //    error.Play();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TocaSonido();
        }

        private void TocaSonido()
        {
            if (sonidos.CurrentState != System.Windows.Media.MediaElementState.Playing)
            {
                sonidos.Position =  new TimeSpan(0, 0, 0, 0,0);
                sonidos.Play();
            }
        }
    }
}