using preacticaExamenDI.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Linq;

namespace App2.Model
{
    public class Concesionario : INotifyPropertyChanged
    {
        private string nombre;
        private ObservableCollection<clsCoche> cochesAVender;

        public event PropertyChangedEventHandler PropertyChanged;

        public Concesionario(String nombre,ObservableCollection<clsCoche> coches)
        {
            this.Nombre = nombre;
            this.CochesAVender = coches;
        }


        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }

        private void OnPropertyChanged(string v)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(v));
            }
        }

        public ObservableCollection<clsCoche> CochesAVender
        {
            get
            {
                return cochesAVender;
            }

            set
            {
                cochesAVender = value;
                OnPropertyChanged("CochesAVender");
            }
        }


    }
}
