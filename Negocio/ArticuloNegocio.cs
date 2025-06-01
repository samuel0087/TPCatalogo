using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Acceso_Datos;

namespace Negocio
{
    internal class ArticuloNegocio
    {

        public List<Articulo> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();
            string query = @"Select 
                                A.Id,
                                A.Codigo,
                                A.Nombre,
                                A.Descripcion,
                                M.Id As IdMarca,
                                M.Descripcion AS Marca,
                                C.Id AS IdCategoria,
                                C.Descripcion AS Categoria,
                                A.ImagenUrl,
                                A.Precio
                                From Articulos A
                                Inner Join Categorias C On C.Id = A.IdCategoria
                                Inner Join Marcas M On M.Id = A.IdMarca";

            try
            {
                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = datos.Lector["Id"] is DBNull ? 0 : (int)datos.Lector["Id"];
                    aux.Nombre = datos.Lector["Nombre"] is DBNull ? "" : (string)datos.Lector["Nombre"];
                    aux.Descripcion = datos.Lector["Descripcion"] is DBNull ? "" : (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.IdMarca = datos.Lector["IdMarca"] is DBNull ? 0 : (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = datos.Lector["Marca"] is DBNull ? "" : (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCategoria = datos.Lector["IdCategoria"] is DBNull ? 0 : (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = datos.Lector["Categoria"] is DBNull ? 0 : (string)datos.Lector["Categoria"];

                    lista.Add(aux);
                }

                return lista;
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
