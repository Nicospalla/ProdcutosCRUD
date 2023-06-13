using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            Boolean validado = true;
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            if (modificar == null)
                modificar = new Articulo();
            if(txtCodigo.Text == "")
            {
                validado= false;
                txtCodigo.BackColor = Color.Red;
            }
            else
            {
                modificar.Codigo = txtCodigo.Text;
            }
            modificar.Nombre = txtNombre.Text;
            modificar.Descripcion = txtDescripcion.Text;
            if(cboCategoria.SelectedIndex == -1 || cboMarca.SelectedIndex == -1)
            {
                validado= false;
                if(cboCategoria.SelectedIndex == -1)
                    lblWarnCat.Visible = true;
                else if(cboMarca.SelectedIndex == -1)
                    lblWarnMarca.Visible = true;
            }
            else
            {
                modificar.Marca = (Marca)cboMarca.SelectedItem;
                modificar.Categoria = (Categoria)cboCategoria.SelectedItem;
            }
            modificar.UrlImagen = txtImagen.Text;
            if (txtPrecio.Text == "")
            {
                validado = false;
                txtPrecio.BackColor = Color.Red;
            }
            else
            {
                string precioCuidado = "";
                if (txtPrecio.Text.Contains(".") || txtPrecio.Text.Contains(" "))
                {
                    precioCuidado = txtPrecio.Text.Replace(".", ",");
                    precioCuidado = txtPrecio.Text.Replace(" ", "");
                }
                else
                    precioCuidado = txtPrecio.Text;

                if (validaNumeros(precioCuidado))
                {
                    modificar.Precio = Decimal.Parse(precioCuidado);
                }
                else
                {
                    txtPrecio.BackColor = Color.Red;
                    validado = false;
                }
            }
            if (validado == false)
            {
                MessageBox.Show("Por favor, corrige las alertas antes de proseguir.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
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
        }

        private Boolean validaNumeros(string cadena)
        {
            char[] caracteres = cadena.ToCharArray();
            int bandera = 0;
            foreach (char c in caracteres)
            {

                if (!char.IsDigit(c) && !(char.IsPunctuation(c) || char.IsSeparator(c)))
                    return false;
                else if (char.IsPunctuation(c) || char.IsSeparator(c))
                    bandera++;
            }
            if (bandera > 1)
                return false;
            else
                return true;

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

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.BackColor = SystemColors.Window;
        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {
            txtPrecio.BackColor = SystemColors.Window;
        }

        private void cboMarca_Click(object sender, EventArgs e)
        {
            lblWarnMarca.Visible = false;
        }

        private void cboCategoria_Click(object sender, EventArgs e)
        {
            lblWarnCat.Visible = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.BackColor = SystemColors.Window;
        }

        private void txtCodigo_Click(object sender, EventArgs e)
        {
            txtCodigo.BackColor= SystemColors.Window;
        }

        private void txtImagen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                cargarImg(txtImagen.Text);
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImg(txtImagen.Text);
        }


    }
}
