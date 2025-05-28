using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Articulo
    {
        private int IdArticulo { set; get; }
        private string Codigo { set; get; }
        private string Nombre { set; get; }
        private string Descripcion { set; get; }
        private Marca Marca { set; get; }
        private Categoria Categoria { set; get; }
        private string ImagenUrl { set; get; }
        private decimal Precio { set; get; }
    }
}
