using ListasObservables.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasObservables.ViewModel
{
    public class LetrasClase : BaseViewModel<Letra>
    {

         /// <summary>
        /// Constructor default
        /// </summary>
        public LetrasClase()

        { 
            //Agregar todas las emociones
            Preguntas.Add(new Letra { Nombre = "Furia",  Sonido = "furia.jpg" });
            Preguntas.Add(new Letra { Nombre = "Felicidad",  Sonido = "felicidad.jpg" });
            Preguntas.Add(new Letra { Nombre = "Amor",  Sonido = "amor.jpg" });

            this.PreguntaActual = Preguntas.First();

        }

    }
}
