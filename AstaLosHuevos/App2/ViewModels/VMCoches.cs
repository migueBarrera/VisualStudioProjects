using App2.Datos;
using preacticaExamenDI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.ViewModels
{
    public class VMCoches : clsVMBase
    {
        private ObservableCollection<clsCoche> _listado;
        private clsCoche coche;

        

        public VMCoches()
        {
            clsDatos datos = new clsDatos();


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
            }
        }
    }
}
