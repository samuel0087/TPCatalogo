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
            ocultarCamposBusqueda();
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
            catch (Exception)
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
            cargar();
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
                    cargar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar Articulo.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult resultado = MessageBox.Show("¿Seguro quieres eliminar este articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(DialogResult.Yes == resultado)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.IdArticulo);
                    MessageBox.Show("Eliminado correctamete");
                    cargar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ocultarCamposBusqueda()
        {
            lblCampo.Visible = false;
            dboCampo.Visible = false;
            lblCriterio.Visible = false;
            dboCriterio.Visible = false;
            btnBuscar.Visible = false;

        }

        private void mostrarCamposBusqueda()
        {
            lblCampo.Visible = true;
            dboCampo.Visible = true;
            lblCriterio.Visible = true;
            dboCriterio.Visible = true;
            btnBuscar.Visible = true;


            dboCampo.Items.Add("Codigo");
            dboCampo.Items.Add("Nombre");
            dboCampo.Items.Add("Descripción");
            dboCampo.Items.Add("Precio");
            dboCampo.Items.Add("Marca");
            dboCampo.Items.Add("Categoria");

            dboCriterio.Enabled = false;
        }



        private void chbAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAvanzado.Checked)
            {
                mostrarCamposBusqueda();
            }
            else
            {
                ocultarCamposBusqueda();
                cargar() ;
            }
        }

        private void dboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dboCriterio.Enabled = true;

                string campo = dboCampo.SelectedItem.ToString();

                switch (campo)
                {
                    case "Codigo":
                    case "Nombre":
                    case "Descripcion":
                        break;

                    case "Precio":
                        break;

                    case "Marca":
                        MarcaNegocio mNegocio  = new MarcaNegocio();
                        dboCriterio.DataSource = mNegocio.listar();
                        break;

                    case "Categoria":
                        CategoriaNegocio nNegocio = new CategoriaNegocio();
                        dboCriterio.DataSource = nNegocio.listar();
                        break;

                    default: 
                        dboCriterio.DataSource=null;
                        dboCriterio.Enabled=false;
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Intentelo mas tarde");
            }
        }
    }
}
