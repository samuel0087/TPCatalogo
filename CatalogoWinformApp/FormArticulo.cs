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
        public FormArticulo()
        {
            InitializeComponent();
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


            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar ventana, intentelo mas tarde");
                Close();
            }
        }
    }
}
