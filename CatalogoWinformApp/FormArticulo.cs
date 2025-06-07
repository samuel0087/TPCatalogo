using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace CatalogoWinformApp
{
    public partial class FormArticulo : Form
    {
        private Articulo articulo = null;
        public FormArticulo()
        {
            InitializeComponent();
        }

        public FormArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio catNegiocio = new CategoriaNegocio();
            MarcaNegocio marNegocio = new MarcaNegocio();

            try
            {
                //Carga la lista desplegable de las categorias
                cbxCategoria.DataSource = catNegiocio.listar();
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DisplayMember = "Descripcion";

                //Carga la lista desplegable de las Marcas
                cbxMarca.DataSource = marNegocio.listar();
                cbxMarca.ValueMember = "IdMarca";
                cbxMarca.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.ImagenUrl;
                    txtPrecio.Text = articulo.Precio.ToString();

                    //Selecciona por defecto la categoria y marca del producto por defecto en los desplegables.
                    cbxCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                    cbxMarca.SelectedValue = articulo.Marca.IdMarca;

                    //Carga la imagen del articulo
                    cargarImagen(articulo.ImagenUrl);

                }


            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar ventana, intentelo mas tarde");
                Close();
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {

                //pbxImagen.Load(ex.ToString());
                pbxImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT9cSGzVkaZvJD5722MU5A-JJt_T5JMZzotcw&s");
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }
    }
}
