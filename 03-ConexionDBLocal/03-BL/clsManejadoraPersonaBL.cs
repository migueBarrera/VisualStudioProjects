using _03_BL;
using _03_ConexionDBLocal_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_DAL.Manejadoras;

namespace _03_BL
{
    public class clsManejadoraPersonaBL
    {
        private clsManejadoraPersonaDAL oManejadoraPersonaDAL = new clsManejadoraPersonaDAL();

        public int insertarPersonaBL(clsPersona persona)
        {
            int resultado = 0;

            resultado = oManejadoraPersonaDAL.insertarPersona(persona);

            return resultado;
        }

        public clsPersona getPersonaBL(int id)
        {
            clsManejadoraPersonaDAL oManejadoraPersonaDAL = new clsManejadoraPersonaDAL();
            clsPersona oPersona = oManejadoraPersonaDAL.getPersonaDAL(id);

            return oPersona;
        }

        public int deletePersona(int id)
        {
            int resultado = 0;

            clsManejadoraPersonaDAL oManejadoraPersonaDAL = new clsManejadoraPersonaDAL();
            resultado = oManejadoraPersonaDAL.borrarPersona(id);

            return resultado;
        }

        public int updatePersona(clsPersona oPersona)
        {
            int resultado = 0;

            clsManejadoraPersonaDAL oManejadoraPersonaDAL = new clsManejadoraPersonaDAL();
            resultado = oManejadoraPersonaDAL.actualizarPersona(oPersona);

            return resultado;
        }
    }
}
