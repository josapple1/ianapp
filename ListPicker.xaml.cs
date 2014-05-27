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
    public partial class ListPicker : PhoneApplicationPage
    {
        public ListPicker()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(ListPicker_Loaded);
        }

        private void ListPicker_Loaded(object sender, RoutedEventArgs e)
        {
            ListBoxRaiz.ItemsSource = MainPage.ListaNombre;  
        }

        private void Seleccion(object sender, GestureEventArgs e)
        {
            ListBox itemseleccionado = (ListBox)sender;
            ItemModelo item = (ItemModelo)itemseleccionado.SelectedItem;
            if (item != null)
            {
                MessageBox.Show(item.Nombre);
                NavigationService.GoBack(); 
            }
        }
    }
}