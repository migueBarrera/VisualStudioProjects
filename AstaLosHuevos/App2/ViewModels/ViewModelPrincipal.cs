using App2.Datos;
using App2.Model;
using System.Collections.ObjectModel;

namespace App2.ViewModels
{
    public class ViewModelPrincipal : clsVMBase
    {
        private ObservableCollection<Concesionario> _consecionarios;
        private Concesionario _consecionarioSelecionado;

        public ViewModelPrincipal()
        {
            clsDatos datos = new clsDatos();
            this.Consecionarios = datos.obtenerListadoConsecionarios();
        }

        public ObservableCollection<Concesionario> Consecionarios
        {
            get
            {
                return _consecionarios;
            }

            set
            {
                _consecionarios = value;
            }
        }

        public Concesionario ConsecionarioSelecionado
        {
            get
            {
                return _consecionarioSelecionado;
            }

            set
            {
                _consecionarioSelecionado = value;
                
            }
        }
    }
}
