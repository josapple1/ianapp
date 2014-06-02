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
    public class TestEmociones  : INotifyPropertyChanged
    {

        /// <summary>
        /// Constructor default
        /// </summary>
        public TestEmociones()

        { 
            //Agregar todas las emociones
            Preguntas.Add(new TestEmocion { Nombre = "Furia", Respuesta = "Respuesta",  Imagen= "furia.jpg" });
            Preguntas.Add(new TestEmocion { Nombre = "Felicidad", Respuesta = "Respuesta", Imagen = "felicidad.jpg" });
            Preguntas.Add(new TestEmocion { Nombre = "Amor", Respuesta = "Respuesta", Imagen = "amor.jpg" });

            this.PreguntaActual = Preguntas.First();

        }

        public int Aciertos
        {
            get;
            set;
        }

        /// <summary>
        /// Las preguntas
        /// </summary>
        ObservableCollection<TestEmocion> preguntas = new ObservableCollection<TestEmocion>();
        public ObservableCollection<TestEmocion> Preguntas 
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
            if(pos<Preguntas.Count -1)
            {
                PreguntaActual = Preguntas[pos + 1];
            }
                
        }

        public bool EsUltima 
        {
            get 
            {
                return Preguntas.IndexOf(PreguntaActual) == Preguntas.Count - 1;
            }
        }

        /// <summary>
        /// la pregunta que se está mostrando
        /// </summary>
        TestEmocion preguntaActual;
        public TestEmocion PreguntaActual
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
