using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace App1
{
    class ConeccionSQL
    {
        //Variables
        private SqlConnection conexion;
        private String sourceURL = "";
        private String user = "";
        private String password = "";

        //Constructores
        public ConeccionSQL(String user,String password)
        {
            
            this.user = user;
            this.password = password;
        }

        //Metodos Consultores
        public String getSourceURL() { return (sourceURL); }
        public String getUser() { return (user); }
        public SqlConnection getConeccionSQL() { return (conexion); }

        //Metodos Modificadores
        public void setSourceURL(String sourceURL) { this.sourceURL = sourceURL; }
        public void serUser(String user) { this.user = user; }
        

        //Metodos Añadidos


        /*		Cabecera : public void establecerConexion();
		 * 	Descripcion:establecera una concexion con la base de datos y  asi podra tener acceso a los usuarios
		 * 				y la contraseña y otros metodos
		 * 	Entradas:
		 * 	Salidas:
		 *  Postcondiciones:establece una concecion con la base de datos ICORT
		 */
        public void establecerConexion()
        {
            try
            {

                conexion = new SqlConnection("Server = DESKTOP-P2SU2D9; Database = Loteria; User Id = " + user+" Password = "+password);
                conexion.Open();
            }
            catch (SqlException)
            {
                
            }

        }

        /*		Cabecera : public void cerrarConexion();
		 * 	Descripcion: cerrara la concecion
		 * 	Entradas:
		 * 	Salidas:
		 *  Postcondiciones:cierra una concecion con la base de datos ICORT
		 */
        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (SqlException e)
            {
               //Captura de errores
            }

        }

        /*		Cabecera : public boolean conectado()
	 * 	Descripcion:comprobara si hay coneccion establecida con el server
	 * 	Entradas:
	 * 	Salidas:boolean
	 *  Postcondiciones: devolvera true en caso de que la coneccion este establecida
	 */
        public bool conectado()
        {
            bool conect = false;

            if (conexion != null)
            {
                conect = true;
            }

            return (conect);
        }

    }
}
