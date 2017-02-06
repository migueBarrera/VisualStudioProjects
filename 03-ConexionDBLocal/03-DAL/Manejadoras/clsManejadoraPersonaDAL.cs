using _03_ConexionDBLocal_ET;
using _03_DAL.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DAL.Manejadoras
{
    public class clsManejadoraPersonaDAL
    {
        private clsMyConnection miconexion;

        public clsManejadoraPersonaDAL()
        {
            miconexion = new clsMyConnection();
        }

        public int insertarPersona(clsPersona persona)
        {
            int numeroFilasAfectadas = 0;

            SqlConnection conexion = new SqlConnection() ;
            SqlCommand miComando = new SqlCommand();

            miComando.Parameters.Add("@nombre",System.Data.SqlDbType.VarChar).Value = persona.nombre;
            miComando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.apellidos;
            miComando.Parameters.Add("@fechaNAc", System.Data.SqlDbType.DateTime).Value = persona.fechaNac;
            miComando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = persona.direccion;
            miComando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.telefono;

            try
            {
                conexion = miconexion.getConnection();
                miComando.CommandText = "INSERT INTO personas(nombre,apellidos,fechaNac,direccion,telefono) VALUES (@nombre,@apellidos,@fechaNac,@direccion,@telefono)";
                miComando.Connection = conexion;
                numeroFilasAfectadas = miComando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw ex;
            }

            return numeroFilasAfectadas;
        }



        public clsPersona getPersonaDAL(int id)
        {
           
            SqlConnection conexion;
            SqlCommand miComando = new SqlCommand();
            clsPersona oPersona = new clsPersona();
            SqlDataReader lector;

            try
            {
                conexion = miconexion.getConnection();
                miComando.CommandText = "SELECT * FROM personas WHERE IDPersona="+id;
                miComando.Connection = conexion;
                lector = miComando.ExecuteReader();

                if(lector.HasRows)
                {
                   if (lector.Read())
                    {
                       
                        oPersona.id = (int)lector[0];
                        oPersona.nombre = (string) lector[1];
                        oPersona.apellidos = (string)lector[2];
                        oPersona.fechaNac = (DateTime)lector[3];
                        oPersona.direccion = (string)lector[4];
                        oPersona.telefono = (string)lector[5];
                    }
                }
                
            }
            catch (SqlException ex)
            {

                throw ex;
            }


            return oPersona;
        }

        public int borrarPersona(int id)
        {
            int numeroFilasAfectadas = 0;
            SqlConnection conexion ;
            SqlCommand miComando = new SqlCommand();

            try
            {
                conexion = miconexion.getConnection();
                miComando.CommandText = "DELETE FROM personas WHERE IDPersona='" + id + "'";
                miComando.Connection = conexion;
                numeroFilasAfectadas = miComando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw ex;
            }


            return numeroFilasAfectadas;

        }

        public int actualizarPersona(clsPersona oPersona)
        {
            int numeroFilasAfectadas = 0;
            SqlConnection conexion;
            SqlCommand miComando = new SqlCommand();

            try
            {
                conexion = miconexion.getConnection();
                miComando.CommandText = "UPDATE [dbo].[personas] SET[nombre] ="+oPersona.nombre+",[apellidos] ="+oPersona.apellidos+",[fechaNac] ="+oPersona.fechaNac+",[direccion] ="+oPersona.direccion+",[telefono] ="+oPersona.telefono+"WHERE IDPersona ="+oPersona.id;
                miComando.Connection = conexion;
                numeroFilasAfectadas = miComando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw ex;
            }


            return numeroFilasAfectadas;
        }
    }
}
