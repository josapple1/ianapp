﻿using ListasObservables.Model;
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
    public class TestEmociones  : BaseViewModel<TestEmocion>
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

        
    }
}
