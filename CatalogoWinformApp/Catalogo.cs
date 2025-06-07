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
            ocultarColumnas();
            cargarImagen(listaArticulos[0].ImagenUrl);

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

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["IdArticulo"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    cargarImagen(seleccionado.ImagenUrl);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar Articulo.");
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    DetalleArticulo detalles = new DetalleArticulo(seleccionado);
                    detalles.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar Articulo.");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormArticulo formularioArticulo = new FormArticulo();
            formularioArticulo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    FormArticulo form = new FormArticulo(seleccionado);
                    form.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar Articulo.");
            }
        }


    }
}
