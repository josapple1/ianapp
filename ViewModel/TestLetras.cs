using ListasObservables.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasObservables.ViewModel
{
    public class TestLetras : LasLetras
    {

        Random rnd = new Random(DateTime.Now.Second);
        public TestLetras()
        {
            //Select the other two
            SeleccionaSiguienteTest();
            PropertyChanged += TestLetras_PropertyChanged;
        }

        void TestLetras_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "PreguntaActual")
                SeleccionaSiguienteTest();
        }


        Letra _Letra1;
        public Letra Letra1
        {
            get 
            {
                return _Letra1;
            }
            set 
            {
                if (_Letra1 == value)
                    return;
                _Letra1 = value;
                NotifyPropertyChanged();
            }
        }

        Letra _Letra2;
        public Letra Letra2
        {
            get
            {
                return _Letra2;
            }
            set
            {
                if (_Letra2 == value)
                    return;
                _Letra2 = value;
                NotifyPropertyChanged();
            }
        }


        Letra _Letra3;
        public Letra Letra3
        {
            get
            {
                return _Letra3;
            }
            set
            {
                if (_Letra3 == value)
                    return;
                _Letra3 = value;
                NotifyPropertyChanged();
            }
        }


        private void SeleccionaSiguienteTest()
        {
            var lt1  = GetAnyButThis(this.PreguntaActual);
            var lt2 = GetAnyButThis(this.PreguntaActual);
            var lt3 = this.PreguntaActual;
            //set them randomly
            var all = new List<Letra>();
            all.Add(lt1);
            all.Add(lt2);
            all.Add(lt3);
            //assign them 
            Letra1 = all[rnd.Next(0, 3)];
            all.Remove(Letra1);
            Letra2 = all[rnd.Next(0, 2)];
            all.Remove(Letra2);
            Letra3 = all.First();
            all.Clear();
        }

        private Letra GetAnyButThis(Letra letra)
        {
            Letra lt2 = null;
            while (lt2 == null || lt2 == letra)
            {
                int idx1 = rnd.Next(0, Preguntas.Count - 1);
                lt2 = Preguntas[idx1];
            }
            return lt2;
        }

        public bool  RespuestaCorrecta(string seleccion)
        {
            return PreguntaActual.Nombre == seleccion;
        }
    }

}
