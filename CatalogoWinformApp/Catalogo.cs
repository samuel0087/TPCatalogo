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
            dboCampo.Items.Clear();
            dboCriterio.Items.Clear();

            lblCampo.Visible = false;
            dboCampo.Visible = false;
            lblCriterio.Visible = false;
            dboCriterio.Visible = false;
            btnEliminarFiltros.Visible = false;
            btnBuscar.Visible = false;

        }

        private void mostrarCamposBusqueda()
        {
            dboCampo.Text = "";
            lblCampo.Visible = true;
            dboCampo.Visible = true;
            lblCriterio.Visible = true;
            dboCriterio.Visible = true;
            btnEliminarFiltros.Visible = true;
            btnBuscar.Visible = true;

            dboCampo.Items.Add("-");
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
                txtBuscar.Visible=true;
                dboCriterio.DataSource = null;
                dboCriterio.Items.Clear();
                dboCriterio.Text = "";
                dboCriterio.Enabled = true;

                string campo = dboCampo.SelectedItem.ToString();

                switch (campo)
                {
                    case "Codigo":
                    case "Nombre":
                    case "Descripción":
                        dboCriterio.Items.Add("Comienza con");
                        dboCriterio.Items.Add("Termina con");
                        dboCriterio.Items.Add("Contiene");
                        break;

                    case "Precio":
                        dboCriterio.Items.Add("Mayor o igual que");
                        dboCriterio.Items.Add("Igual que");
                        dboCriterio.Items.Add("Menor o igual que");
                        break;

                    case "Marca":
                        txtBuscar.Visible = false;
                        txtBuscar.Text = "";
                        MarcaNegocio mNegocio  = new MarcaNegocio();
                        dboCriterio.DataSource = mNegocio.listar();
                        break;

                    case "Categoria":
                        txtBuscar.Visible = false;
                        txtBuscar.Text = "";
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

        private void btnEliminarFiltros_Click(object sender, EventArgs e)
        {
            dboCampo.SelectedIndex = 0;
            txtBuscar.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string campo = dboCampo.SelectedItem.ToString();
                string criterio = dboCriterio.SelectedItem.ToString();
                string filtro = txtBuscar.Text;

                dgvArticulos.DataSource = negocio.filtroAvanzado(campo, criterio, filtro);
            }
            catch (Exception)
            {

                MessageBox.Show("Imposible buscar en este momento, intentelo nuevamente más tarde :)");
            }
        }
    }
}
