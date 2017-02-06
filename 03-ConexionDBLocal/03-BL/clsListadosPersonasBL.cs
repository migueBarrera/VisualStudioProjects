using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_DAL.Listados;
using _03_ConexionDBLocal_ET;
using _03_BL;

namespace _03_BL
{
    public class clsListadosPersonasBL
    {
        public List<clsPersona> getListadoPersonasBL()
        {
            List < clsPersona > lista = new List<clsPersona>();
            clsListadoDAL miLista = new clsListadoDAL();

            lista = miLista.getListadoPersonasDAL();

            return lista;
        }

       
    }
}
