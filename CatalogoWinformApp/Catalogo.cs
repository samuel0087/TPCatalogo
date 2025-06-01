using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace CatalogoWinformApp
{
    public partial class Catalogo : Form
    {
        private List<Articulo> listaArticulos;
        public Catalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
