using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Acceso_Datos;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
			AccesoDatos datos = new AccesoDatos();
			List<Categoria> listado = new List<Categoria>();
			string query = "Select Id, Descripcion From Categorias";

			try
			{
				datos.setearConsulta(query);
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Categoria aux = new Categoria();
					aux.IdCategoria = datos.Lector["Id"] is DBNull ? 0 : (int)datos.Lector["Id"];
					aux.Descripcion = datos.Lector["Descripcion"] is DBNull ? "" : (string)datos.Lector["Descripcion"];

					listado.Add(aux);
				}

				return listado;
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally 
			{
				datos.cerrarConexion();
			}
        }
    }
}
