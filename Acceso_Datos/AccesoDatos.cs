using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Acceso_Datos
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //Se crea la conexion a la base de datos en el constructor
        public AccesoDatos()
        {
            const string DB = "CATALOGO_DB"; //Nombre de la base de datos
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=" + DB + "; integrated security=true");
            comando = new SqlCommand();
        }

        //Recibe la consulta
        public void setearConsulta(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }

        //Setea el parametro deseado
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        //Ejecuta la consulta Sql y guarda el resultado en el lector
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecitarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void cerrarConexion()
        {
            try
            {
                if (lector != null && !lector.IsClosed)
                {
                    lector.Close();
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                // Manejar excepciones, si es necesario
                throw new Exception("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}
