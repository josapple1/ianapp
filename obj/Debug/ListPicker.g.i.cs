﻿#pragma checksum "C:\Users\oooo\Documents\Visual Studio 2010\Projects\ListasObservables\ListasObservables\ListPicker.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "569E71F2215EB90F6A261D20168F7A38"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.1022
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ListasObservables {
    
    
    public partial class ListPicker : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.ListBox ListBoxRaiz;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/ListasObservables;component/ListPicker.xaml", System.UriKind.Relative));
            this.ListBoxRaiz = ((System.Windows.Controls.ListBox)(this.FindName("ListBoxRaiz")));
        }
    }
}
