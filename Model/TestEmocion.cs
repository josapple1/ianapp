using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasObservables.Model
{
    public class TestEmocion : Emocion
    {
        string respuesta;

        public string Respuesta 
        {
            get { return respuesta; }
            set 
            { 
                if (value != respuesta)
                {
                    respuesta = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("RespuestaCorrecta");
                }
            }
        }

        public bool RespuestaCorrecta 
        {
            get 
            {
                return this.Respuesta.ToLower() == this.Nombre.ToLower();
            }
    }
}
