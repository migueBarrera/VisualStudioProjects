using ejercicio2_binding_di.ViewModels;
using preacticaExamenDI.Datos;
using preacticaExamenDI.Model;
using System.Collections.ObjectModel;
using System;

namespace preacticaExamenDI.ViewModel
{
    public class VMPrincipal : clsVMBase
    {
        private ObservableCollection<clsCoche> _listado;
        private clsCoche coche;
        //DelegatesCommands
        private DelegateCommand _eliminarComand;
        private DelegateCommand _buscarCommand;
        private String cadenaABuscar;


        public VMPrincipal()
        {
            clsDatos datos = new clsDatos();
            this.Listado = datos.obtenerListadoCoches();
        }


        public ObservableCollection<clsCoche> Listado
        {
            get
            {
                return _listado;
            }

            set
            {
                _listado = value;
            }
        }

        public clsCoche Coche
        {
            get
            {
                return coche;
            }

            set
            {
                coche = value;
                _eliminarComand.RaiseCanExecuteChanged();
                NotifyPropertyChanged("Coche");
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

        public DelegateCommand buscarCommand
        {
            get
            {
                _buscarCommand = new DelegateCommand(buscarCommand_executed, buscarCommand_Canexecute);
                return _buscarCommand;
            }

        }

        public string CadenaABuscar
        {
            get
            {
                return cadenaABuscar;
            }

            set
            {
                cadenaABuscar = value;
                _buscarCommand = new DelegateCommand(buscarCommand_executed, buscarCommand_Canexecute);
            }
        }

        private bool buscarCommand_Canexecute()
        {
            return true;
        }

        private void buscarCommand_executed()
        {
          
        }

        private bool eliminarComand_Canexecute()
        {
            bool sepuedeeliminar;

            if (Coche == null)
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
            Listado.Remove(Coche);

        }
    }
}
