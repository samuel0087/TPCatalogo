using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoWinformApp
{
    public partial class DetalleArticulo : Form
    {
        public DetalleArticulo(Articulo articulo)
        {
            InitializeComponent();

            try
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtCategoria.Text = articulo.Categoria.ToString();
                txtMarca.Text = articulo.Marca.ToString();
                txtPrecio.Text = articulo.Precio.ToString();
                cargarImagen(articulo.ImagenUrl);

            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar Articulo");
                Close();
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception)
            {

                //pbxImagen.Load(ex.ToString());
                pbxImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9cSGzVkaZvJD5722MU5A-JJt_T5JMZzotcw&s");
            }
        }

        private void txtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
