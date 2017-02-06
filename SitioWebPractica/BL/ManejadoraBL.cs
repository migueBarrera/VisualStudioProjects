using Modelos;
using System.Collections.Generic;
using DAL.Manejadoras;

namespace BL
{
    public class ManejadoraBL
    {

        public List<clsPersona> obtenerListadoPersonasBL()
        {
            ManejadoraDAL manejadoraDAl = new ManejadoraDAL();
            List<clsPersona> miLista = manejadoraDAl.obtenerListadoPersonasDAL();

            return miLista;
        }

        public clsPersona obtenerPersonaBL(int id)
        {
            ManejadoraDAL manejadoraDAL = new ManejadoraDAL();
            clsPersona oPersona = manejadoraDAL.obtenerPersonaDAL(id);

            return oPersona;
        }

        public int insertarPersonaBL(clsPersona persona)
        {
            ManejadoraDAL manejadoraDAL = new ManejadoraDAL();
            int res = 0;

            res = manejadoraDAL.insertarPersona(persona);

            return res;
        }

        public int borrarPersonaBL(int id)
        {
            ManejadoraDAL manejadoraDAL = new ManejadoraDAL();
            int res = 0;

            res = manejadoraDAL.borrarPersona(id);

            return res;
        }

        public int actualizarPersona(clsPersona persona)
        {
            int res = 0;

            ManejadoraDAL manejadoraDal = new ManejadoraDAL();
            res = manejadoraDal.actualizarPersona(persona);

            return res;
        }
    }
}
