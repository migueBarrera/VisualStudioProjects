using ejercicio2_binding_di.Models;
using System.Collections.ObjectModel;

namespace ejercicio2_binding_di.ViewModels
{
    public  class clsMainPageVM : clsVMBase
    {
        #region "Atributos"
        private clsPersona _personaSeleccionada;
        private ObservableCollection<clsPersona> _listado;
       // private DelegateCommand __buscarComand;
        private DelegateCommand _eliminarComand;
        //private String _textoABuscar;
        #endregion

        public clsMainPageVM()
        {
            clsListado lista = new clsListado();
            _listado = lista.getListado();
        }

        public clsPersona personaSeleccionada
        {
            get
            {
                return _personaSeleccionada;
            }
            set
            {
                _personaSeleccionada = value;
                _eliminarComand.RaiseCanExecuteChanged();
                NotifyPropertyChanged("personaSeleccionada");
  
            }
        }
        public ObservableCollection<clsPersona> listado
        {
            get
            {
                return _listado;
            }
        }

        public DelegateCommand eliminarComand
        {
            get
            {
                _eliminarComand = new DelegateCommand(eliminarComand_executed, eliminarComand_Canexecute);
                return _eliminarComand;
            }
        }
        #region "Funciones y metodos"

        private bool eliminarComand_Canexecute()
        {
            bool sepuedeeliminar ;

            if (personaSeleccionada == null)
            {
                sepuedeeliminar = false;
            }
            else
            {
                sepuedeeliminar = true;
            }

            return sepuedeeliminar;
        }

        private void eliminarComand_executed()
        {
            listado.Remove(personaSeleccionada);

        }

        #endregion

        //protected void OnPropertyChanged(string name)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null)
        //    {
        //        handler(this, new PropertyChangedEventArgs(name));
        //    }
        //}


    }

}
