using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_ConexionDBLocal_ET;
using System.Data.SqlClient;
using _03_DAL.Conexion;


namespace _03_DAL.Listados
{
    public class clsListadoDAL
    {
        public List<clsPersona> getListadoPersonasDAL()
        {
            List<clsPersona> personas;
            clsMyConnection miConexion;
            clsPersona opersona;

            personas = new List<clsPersona>();


            miConexion = new clsMyConnection();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select * FROM personas";
            SqlDataReader lector;
            

            try
            {
                conexion = miConexion.getConnection();              
                comando.Connection = conexion;
                lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        opersona = new clsPersona();
                        opersona.id = (int)lector["IDPersona"];
                        opersona.nombre = (string)lector["nombre"];
                        opersona.apellidos = (string)lector["apellidos"];
                        opersona.fechaNac = (DateTime)lector["fechaNac"];
                        opersona.direccion = (string)lector["direccion"];
                        opersona.telefono = (string)lector["telefono"];
                        personas.Add(opersona);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            

            return (personas);
        }
    }
}
