using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preacticaExamenDI.Model
{
    public class clsCoche : INotifyPropertyChanged
    {
        private String _fabricante;
        private String _tipo;
        private String _modelo;
        private String _motor;
        private double _caballos;

        public event PropertyChangedEventHandler PropertyChanged;

        public clsCoche()
        {
            Fabricante = "";
            Tipo = "";
            Modelo = "";
            Motor = "";
            Caballos = 0;
        }

        public clsCoche(String fabricante,String tipo,String modelo,String motor,Double caballos)
        {
            Fabricante = fabricante;
            Tipo = tipo;
            Modelo = modelo;
            Motor = motor;
            Caballos = caballos;
        }

        public string Fabricante
        {
            get
            {
                return _fabricante;
            }

            set
            {
                _fabricante = value;
                OnPropertyChanged("Fabricante");
            }
        }

        public string Tipo
        {
            get
            {
                return _tipo;
            }

            set
            {
                _tipo = value;
                OnPropertyChanged("Tipo");
            }
        }

        public string Modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                _modelo = value;
                OnPropertyChanged("Modelo");
            }
        }


        public string Motor
        {
            get
            {
                return _motor;
            }

            set
            {
                _motor = value;
                OnPropertyChanged("Motor");
            }
        }

        public double Caballos
        {
            get
            {
                return _caballos;
            }

            set
            {
                _caballos = value;
                OnPropertyChanged("Caballos");
            }
        }
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
