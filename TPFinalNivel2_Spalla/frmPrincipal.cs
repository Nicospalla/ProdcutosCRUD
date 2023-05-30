using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPFinalNivel2_Spalla
{
    public partial class frmPrincipal : Form
    {
        private List<Articulo> lista;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                lista = negocio.listar();
                dgvPrincipal.DataSource = lista;
                ocultarColumnas();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ocultarColumnas()
        {       
            dgvPrincipal.Columns["Id"].Visible = false;
            dgvPrincipal.Columns["UrlImagen"].Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult resultado = MessageBox.Show("Seguro deseas eliminar el articulo?", "Eliminar articulo", MessageBoxButtons.YesNo);
                if(resultado == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                    negocio.eliminarArt(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAuxiliar agregar = new frmAuxiliar();
            agregar.ShowDialog();
            cargar();
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
