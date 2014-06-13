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
using ListasObservables.ViewModel;

namespace ListasObservables
{
    public partial class Page4 : PhoneApplicationPage
    {

        protected TestEmociones ViewModel;

        public Page4()
        {
            InitializeComponent();
            ViewModel = new TestEmociones();
            this.DataContext = ViewModel;
            this.cmdSiguiente.IsEnabled = false;
        }

        private void tbUsuario_GotFocus(object sender, RoutedEventArgs e)
        {
            if (this.tbRespuesta.Text == "Respuesta")
                this.tbRespuesta.Text = string.Empty;
        }

        private void tbRespuesta_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.tbRespuesta.Text))
                this.tbRespuesta.Text = "Respuesta";
        }

        private void cmdAceptar_Click(object sender, RoutedEventArgs e)
        {
            ChecarRespuesta();
        }

        protected void ChecarRespuesta()
        {
            if (ViewModel.PreguntaActual.RespuestaCorrecta)
            {
                this.cmdSiguiente.IsEnabled = true;
                this.tbMensaje.Text = "Correcto";
            }
            else
            {
                this.cmdSiguiente.IsEnabled = false;
                this.tbMensaje.Text = "Incorrecto";
            }
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
                MessageBox.Show("Has terminado!"  , "Felicidades!", MessageBoxButton.OK);
                NavigationService.Navigate(new Uri("/Portada.xaml", UriKind.Relative));
            }
        }

        private void cmdAyuda_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ViewModel.Help, "Escoge entre", MessageBoxButton.OK);
        }

        private void tbRespuesta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                this.cmdAceptar.Focus();
        }

        

       
    }
}