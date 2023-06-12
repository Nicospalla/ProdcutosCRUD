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
        ArticuloNegocio negocio = new ArticuloNegocio();
        MarcaNegocio marcaNegocio = new MarcaNegocio(); 
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargar();
            cboMarca.DataSource = marcaNegocio.listar();
            cboMarca.ValueMember = "id";
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.SelectedIndex = -1;
            cboCat.DataSource = categoriaNegocio.listar();
            cboCat.ValueMember = "id";
            cboCat.DisplayMember = "Descripcion";
            cboCat.SelectedIndex = -1;
          
        }

        public void cargar()
        {
            
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
            dgvPrincipal.Focus();

        }

        public void ocultarColumnas()
        {
            dgvPrincipal.Columns["Id"].Visible = false;
            dgvPrincipal.Columns["UrlImagen"].Visible = false;
        }
        public void ordenarLista(int bandera)
        {
            List<Articulo> listaOrdenada;
            if (bandera == 1)
            {
                listaOrdenada = lista;
                lista.Sort((x, y) => string.Compare(x.Marca.Descripcion, y.Marca.Descripcion));
                dgvPrincipal.DataSource = null;
                dgvPrincipal.DataSource = lista;
                ocultarColumnas();
            }
            else if(bandera == 2)
            {
                lista.Sort((x, y) => string.Compare(x.Categoria.Descripcion, y.Categoria.Descripcion));
                dgvPrincipal.DataSource = null;
                dgvPrincipal.DataSource = lista;
                ocultarColumnas();
            }
            else if (bandera == 3)
            {
                lista.Sort((x, y) => Decimal.Compare(x.Precio, y.Precio));
                dgvPrincipal.DataSource = null;
                dgvPrincipal.DataSource = lista;
                ocultarColumnas();
            } 
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            if (dgvPrincipal.CurrentRow != null)
            {
                try
                {
                    DialogResult resultado = MessageBox.Show("Seguro deseas eliminar el articulo?", "Eliminar articulo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                        negocio.eliminarArt(seleccionado.Id);
                        cargar();
                        dgvLimpieza();

                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona algún item de la lista.", "Error al seleccionar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAuxiliar agregar = new frmAuxiliar();
            agregar.ShowDialog();
            dgvLimpieza();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
                frmAuxiliar modificar = new frmAuxiliar((Articulo)dgvPrincipal.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                cargar();
                dgvLimpieza();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona algún item de la lista.", "Error al seleccionar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null) { 
                frmAuxiliar modificar = new frmAuxiliar((Articulo)dgvPrincipal.CurrentRow.DataBoundItem, 1);
            modificar.ShowDialog();
                dgvLimpieza();
                cargar();
            }
            else 
            {
                MessageBox.Show("Por favor, selecciona algún item de la lista.","Error al seleccionar producto",MessageBoxButtons.OK,MessageBoxIcon.Error);    
            }
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
                ocultarColumnas();
                
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


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int cat;
            int marca;
            if (cboCat.SelectedIndex == -1 && cboMarca.SelectedIndex != -1)
            {
                marca = cboMarca.SelectedIndex + 1;
                dgvPrincipal.DataSource = negocio.filtroAvanzado(marca,1);
            }
            else if (cboMarca.SelectedIndex == -1 && cboCat.SelectedIndex != -1)
            {
                cat = cboCat.SelectedIndex + 1;
                dgvPrincipal.DataSource = negocio.filtroAvanzado(cat, 2);
            }
            else if (cboMarca.SelectedIndex != -1 && cboCat.SelectedIndex != -1)
            {
                marca = cboMarca.SelectedIndex + 1;
                cat = cboCat.SelectedIndex + 1;
                dgvPrincipal.DataSource = negocio.filtroAvanzado(cat, 3, marca);
            }
            else
                cargar();
            
        }

        private void dgvLimpieza()
        {
            cboCat.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            txtFiltro.Text = string.Empty;
            cargar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvLimpieza();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            dgvLimpieza();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvLimpieza();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            ordenarLista(1);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            ordenarLista(2);
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            ordenarLista(3);
        }
     
    }
}

