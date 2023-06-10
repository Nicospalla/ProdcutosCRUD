using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
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
                lista.Sort((x, y) => string.Compare(x.Marca.Descripcion, y.Marca.Descripcion));

            }
            catch (Exception ex)
            {
                throw ex;
            }
            dgvPrincipal.Focus();
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
            frmAuxiliar modificar = new frmAuxiliar((Articulo)dgvPrincipal.CurrentRow.DataBoundItem);
            modificar.ShowDialog();
            cargar();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            frmAuxiliar modificar = new frmAuxiliar((Articulo)dgvPrincipal.CurrentRow.DataBoundItem, 1);
            modificar.ShowDialog();
            cargar();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text.ToLower();
            try
            {
                if(filtro.Length > 1)
                {
                    listaFiltrada = lista.FindAll(x => x.Codigo.ToLower().Contains(filtro) || x.Nombre.ToLower().Contains(filtro) || x.Marca.Descripcion.ToLower().Contains(filtro) || x.Categoria.Descripcion.ToLower().Contains(filtro));
                }
                else
                {
                    listaFiltrada = lista;
                }
                dgvPrincipal.DataSource = null;
                dgvPrincipal.DataSource = listaFiltrada;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtFiltro_MouseHover(object sender, EventArgs e)
        {
            lblFiltro.Visible = true;
        }

        private void txtFiltro_MouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(400);
            lblFiltro.Visible = false;
        }


    }
}
