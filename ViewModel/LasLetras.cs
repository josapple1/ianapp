using ListasObservables.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasObservables.ViewModel
{
    public class LasLetras : BaseViewModel<Letra>
    {

         /// <summary>
        /// Constructor default
        /// </summary>
        public LasLetras()
        { 
            //Agregar todas las emociones
            for (var x = 97; x < 123; x++)
            {
                string letra = new String(Convert.ToChar(x), 1);

                Preguntas.Add(new Letra { Nombre = letra, Sonido = letra + ".mp3" });
            }
                

            this.PreguntaActual = Preguntas.First();
            
        }

    }
}
