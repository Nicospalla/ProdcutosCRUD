using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalNivel2_Spalla
{
    public partial class frmAuxiliar : Form
    {
        MarcaNegocio aux = new MarcaNegocio();
        CategoriaNegocio auxCat = new CategoriaNegocio();
        AccesoDatos datos = new AccesoDatos();
        
        public frmAuxiliar()
        {
            InitializeComponent();
        }
        private void frmAuxiliar_Load(object sender, EventArgs e)
        {
            cboMarca.DataSource = aux.listar();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Marca";
            cboMarca.SelectedIndex = -1;
            cboCategoria.DataSource = auxCat.listar();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Categoria";
            cboCategoria.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevo = new Articulo();
            nuevo.Codigo = txtCodigo.Text;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Marca = (Marca)cboMarca.SelectedItem;
            nuevo.Categoria =(Categoria)cboCategoria.SelectedItem;
            nuevo.UrlImagen = txtImagen.Text;
            nuevo.Precio = Decimal.Parse(txtPrecio.Text);
            frmPrincipal frm = new frmPrincipal();

            try
            {
                negocio.agregarArg(nuevo);
                this.Close();

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

        private void txtImagen_TextChanged(object sender, EventArgs e)
        {
            string imagen = txtImagen.Text;
            pboxImagen.Load(imagen);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
