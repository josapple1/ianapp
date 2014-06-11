using ListasObservables.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListasObservables.ViewModel
{
    public abstract class BaseViewModel<T> : INotifyPropertyChanged where T : class, new()
    {

        public int Aciertos
        {
            get;
            set;
        }

        /// <summary>
        /// Las preguntas
        /// </summary>
        ObservableCollection<T> preguntas = new ObservableCollection<T>();
        public ObservableCollection<T> Preguntas
        {
            get
            {
                return preguntas;
            }
        }


        public void SiguientePregunta()
        {
            var pos = Preguntas.IndexOf(PreguntaActual);
            //Mover al siguiente
            if (pos < Preguntas.Count - 1)
            {
                PreguntaActual = Preguntas[pos + 1];
            }

        }

        public void AnteriorPregunta()
        {
            var pos = Preguntas.IndexOf(PreguntaActual);
            //Mover al siguiente
            if (pos > 0)
            {
                PreguntaActual = Preguntas[pos  - 1];
            }

        }


        public bool EsUltima
        {
            get
            {
                return Preguntas.IndexOf(PreguntaActual) == Preguntas.Count - 1;
            }
        }

        public bool EsPrimera
        {
            get 
            {
                return Preguntas.IndexOf(preguntaActual) == 0;
            }
        }

        /// <summary>
        /// la pregunta que se está mostrando
        /// </summary>
        T preguntaActual;
        public T PreguntaActual
        {
            get
            {
                return preguntaActual;
            }
            set
            {

                if (preguntaActual != value)
                {
                    preguntaActual = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Notify all subscribers
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
