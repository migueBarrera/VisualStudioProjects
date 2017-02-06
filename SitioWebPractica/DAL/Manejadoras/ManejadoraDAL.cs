using DAL.coneccion;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Manejadoras
{
    public class ManejadoraDAL
    {
        private clsMyConnection conn;
        public ManejadoraDAL()
        {
            conn = new clsMyConnection();
        }

        public List<clsPersona> obtenerListadoPersonasDAL()
        {
            List<clsPersona> miLista = new List<clsPersona>();
            String sql = "Select * From personas";
            clsPersona opersona;

            SqlCommand comando = new SqlCommand();
            comando.CommandText = sql;
            comando.Connection = conn.getConnection();
            SqlDataReader lector;

            try
            {
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
                        miLista.Add(opersona);
                    }
                }


            }
            catch (SqlException e)
            {

                throw;
            }
            finally
            {
                conn.closeConnection(comando.Connection);
            }

            return miLista;
        }

        public clsPersona obtenerPersonaDAL(int id)
        {
            SqlCommand comand = new SqlCommand();
            SqlDataReader lector;
            clsPersona opersona = new clsPersona();
            String sql = "Select * From personas where IDPersona=" + id;

            comand.CommandText = sql;
            comand.Connection = conn.getConnection();

            try
            {
                lector = comand.ExecuteReader();

                if (lector.HasRows)
                {
                   if(lector.Read())
                    {
                        
                        opersona.id = (int)lector["IDPersona"];
                        opersona.nombre = (string)lector["nombre"];
                        opersona.apellidos = (string)lector["apellidos"];
                        opersona.fechaNac = (DateTime)lector["fechaNac"];
                        opersona.direccion = (string)lector["direccion"];
                        opersona.telefono = (string)lector["telefono"];
                    }
                }
            }
            catch (SqlException e)
            {

                throw e;
            }
            finally
            {
                conn.closeConnection(comand.Connection);
            }

            return opersona;
        }

        public int insertarPersona(clsPersona persona)
        {
            int res = 0;
            SqlCommand comando = new SqlCommand();
            
           
            comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.nombre;
            comando.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.apellidos;
            comando.Parameters.Add("@fechaNac", System.Data.SqlDbType.DateTime).Value = persona.fechaNac;
            comando.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = persona.direccion;
            comando.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.telefono;

            String sql = "INSERT into personas(nombre,apellidos,fechaNac,direccion,telefono) Values "
                +"(@nombre,@apellidos,@fechaNac,@direccion,@telefono)";
            comando.CommandText = sql;
            try
            {
               
               comando.Connection = conn.getConnection();
               res =  comando.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                conn.closeConnection(comando.Connection);
            }

            return res;
        }

        public int borrarPersona(int id)
        {
            int res = 0;
            SqlCommand comando = new SqlCommand();

            String sql = "DELETE FROM personas WHERE IDPersona='" + id + "'";
            comando.CommandText = sql;

            try
            {
                comando.CommandText = sql;
                comando.Connection = conn.getConnection();
                res = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            return res;
        }

        public int actualizarPersona(clsPersona persona)
        {

            int correcto = 0;
            SqlCommand miCommand = new SqlCommand();

            try
            {
                miCommand.Connection = conn.getConnection();
                miCommand.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = persona.id;
                miCommand.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = persona.nombre;
                miCommand.Parameters.Add("@apellidos", System.Data.SqlDbType.VarChar).Value = persona.apellidos;
                miCommand.Parameters.Add("@fechaNac", System.Data.SqlDbType.DateTime).Value = persona.fechaNac;
                miCommand.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = persona.direccion;
                miCommand.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = persona.telefono;

                miCommand.CommandText = "Update personas set nombre=@nombre,apellidos=@apellidos," +
                    "fechaNac=@fechaNac,direccion=@direccion,telefono=@telefono Where IDPersona=@id";
                correcto = miCommand.ExecuteNonQuery();
                correcto = correcto + 1;
                correcto--;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                conn.closeConnection(miCommand.Connection);
            }
            return correcto;
        }
    }

}
