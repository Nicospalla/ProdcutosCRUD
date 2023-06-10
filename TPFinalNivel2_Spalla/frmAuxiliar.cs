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
using static System.Net.Mime.MediaTypeNames;

namespace TPFinalNivel2_Spalla
{
    public partial class frmAuxiliar : Form
    {
        MarcaNegocio aux = new MarcaNegocio();
        CategoriaNegocio auxCat = new CategoriaNegocio();
        AccesoDatos datos = new AccesoDatos();
        Articulo modificar;
        public int banderaDetalles = 0;
        
        public frmAuxiliar()
        {
            InitializeComponent();
        }

        public frmAuxiliar(Articulo modificar, int bandera = 0)
        {
            if(bandera == 0) {
                InitializeComponent();
                this.modificar = modificar;
                Text = "Modificar un Producto";
            } else
            {
                InitializeComponent();
                this.modificar = modificar;
                this.banderaDetalles= bandera;
                Text = "Ver detalle de Producto";
            }

        }

       
        private void frmAuxiliar_Load(object sender, EventArgs e)
        {
        
                cboMarca.DataSource = aux.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.SelectedIndex = -1;
                cboCategoria.DataSource = auxCat.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.SelectedIndex = -1;
            
            if (modificar != null)
            {
                txtCodigo.Text = modificar.Codigo.ToString();
                txtNombre.Text = modificar.Nombre.ToString();
                txtDescripcion.Text = modificar.Descripcion.ToString();
                cboMarca.SelectedValue = modificar.Marca.id;
                cboCategoria.SelectedValue = modificar.Categoria.id;
                txtImagen.Text = modificar.UrlImagen.ToString();
                cargarImg(modificar.UrlImagen);
                txtPrecio.Text = modificar.Precio.ToString();
            }    
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            if (modificar == null)
                modificar = new Articulo();
           
                modificar.Codigo = txtCodigo.Text;
                modificar.Nombre = txtNombre.Text;
                modificar.Descripcion = txtDescripcion.Text;
            modificar.Marca = (Marca)cboMarca.SelectedItem;
                modificar.Categoria = (Categoria)cboCategoria.SelectedItem;
                modificar.UrlImagen = txtImagen.Text;
                if (txtPrecio.Text.Contains("."))
                    modificar.Precio = Decimal.Parse(txtPrecio.Text.Replace(".", ","));
                else
                    modificar.Precio = Decimal.Parse(txtPrecio.Text);
            
            frmPrincipal frm = new frmPrincipal();

            try
            {
                if (banderaDetalles == 0)
                {
                    if (modificar.Id == 0)
                        negocio.agregarArg(modificar);
                    else
                        negocio.modificarArg(modificar);
                }
                
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
            cargarImg(imagen);
        }

        private void cargarImg(string imagen)
        {
            try
            {
                    pboxImagen.Load(imagen);
            }
            catch (Exception)
            {
                pboxImagen.Load("https://repuestosmisleh.cl/assets/img/default.png");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
