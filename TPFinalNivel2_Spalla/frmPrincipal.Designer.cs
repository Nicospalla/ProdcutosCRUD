namespace TPFinalNivel2_Spalla
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelVertical = new System.Windows.Forms.Panel();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.lblCat = new System.Windows.Forms.Label();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblFiltroRap = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.panelVertical.SuspendLayout();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVertical
            // 
            this.panelVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.panelVertical.Controls.Add(this.btnCargar);
            this.panelVertical.Controls.Add(this.btnCerrar);
            this.panelVertical.Controls.Add(this.btnDetalles);
            this.panelVertical.Controls.Add(this.btnEliminar);
            this.panelVertical.Controls.Add(this.btnModificar);
            this.panelVertical.Controls.Add(this.btnAgregar);
            this.panelVertical.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelVertical.Location = new System.Drawing.Point(776, 0);
            this.panelVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(237, 674);
            this.panelVertical.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCargar.Location = new System.Drawing.Point(21, 453);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(192, 71);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Recargar Lista";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(165, 602);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(60, 60);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.btnDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalles.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDetalles.FlatAppearance.BorderSize = 0;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDetalles.Location = new System.Drawing.Point(21, 361);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(192, 71);
            this.btnDetalles.TabIndex = 3;
            this.btnDetalles.Text = "Ver Detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(21, 270);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(192, 71);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location = new System.Drawing.Point(21, 177);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(192, 71);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar Producto";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(21, 85);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(192, 71);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(156)))), ((int)(((byte)(148)))));
            this.panelInferior.Controls.Add(this.btnPrecio);
            this.panelInferior.Controls.Add(this.btnCat);
            this.panelInferior.Controls.Add(this.btnMarca);
            this.panelInferior.Controls.Add(this.label1);
            this.panelInferior.Controls.Add(this.btnCancelar);
            this.panelInferior.Controls.Add(this.btnLimpiar);
            this.panelInferior.Controls.Add(this.btnFiltrar);
            this.panelInferior.Controls.Add(this.dgvPrincipal);
            this.panelInferior.Controls.Add(this.lblCat);
            this.panelInferior.Controls.Add(this.cboCat);
            this.panelInferior.Controls.Add(this.cboMarca);
            this.panelInferior.Controls.Add(this.lblMarca);
            this.panelInferior.Controls.Add(this.lblFiltro);
            this.panelInferior.Controls.Add(this.lblFiltroRap);
            this.panelInferior.Controls.Add(this.txtFiltro);
            this.panelInferior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInferior.Location = new System.Drawing.Point(0, 0);
            this.panelInferior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(776, 674);
            this.panelInferior.TabIndex = 0;
            // 
            // btnPrecio
            // 
            this.btnPrecio.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecio.Location = new System.Drawing.Point(409, 71);
            this.btnPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(95, 34);
            this.btnPrecio.TabIndex = 14;
            this.btnPrecio.Text = "Precio";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // btnCat
            // 
            this.btnCat.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat.Location = new System.Drawing.Point(289, 71);
            this.btnCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(95, 34);
            this.btnCat.TabIndex = 13;
            this.btnCat.Text = "Categoría";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.Location = new System.Drawing.Point(167, 70);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(95, 34);
            this.btnMarca.TabIndex = 12;
            this.btnMarca.Text = "Marca";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(14, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ordenar por:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(673, 30);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(640, 608);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 44);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(547, 608);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(83, 44);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowDrop = true;
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.AllowUserToOrderColumns = true;
            this.dgvPrincipal.AllowUserToResizeColumns = false;
            this.dgvPrincipal.AllowUserToResizeRows = false;
            this.dgvPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPrincipal.Location = new System.Drawing.Point(25, 120);
            this.dgvPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrincipal.MultiSelect = false;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowHeadersVisible = false;
            this.dgvPrincipal.RowHeadersWidth = 51;
            this.dgvPrincipal.RowTemplate.Height = 24;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(739, 474);
            this.dgvPrincipal.TabIndex = 0;
            // 
            // lblCat
            // 
            this.lblCat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCat.Location = new System.Drawing.Point(271, 616);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(101, 30);
            this.lblCat.TabIndex = 7;
            this.lblCat.Text = "Categoría:";
            // 
            // cboCat
            // 
            this.cboCat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(382, 618);
            this.cboCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(155, 24);
            this.cboCat.TabIndex = 6;
            // 
            // cboMarca
            // 
            this.cboMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(103, 618);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(159, 24);
            this.cboMarca.TabIndex = 4;
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMarca.Location = new System.Drawing.Point(20, 616);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 30);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(195, 9);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(418, 26);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Puede filtrar por código, nombre, marca o categoría.";
            this.lblFiltro.Visible = false;
            // 
            // lblFiltroRap
            // 
            this.lblFiltroRap.AutoSize = true;
            this.lblFiltroRap.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblFiltroRap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.lblFiltroRap.Location = new System.Drawing.Point(16, 30);
            this.lblFiltroRap.Name = "lblFiltroRap";
            this.lblFiltroRap.Size = new System.Drawing.Size(128, 30);
            this.lblFiltroRap.TabIndex = 1;
            this.lblFiltroRap.Text = "Filtro rápido:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.txtFiltro.Location = new System.Drawing.Point(167, 34);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(496, 22);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            this.txtFiltro.MouseLeave += new System.EventHandler(this.txtFiltro_MouseLeave);
            this.txtFiltro.MouseHover += new System.EventHandler(this.txtFiltro_MouseHover);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1013, 674);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelVertical);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(999, 648);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Productos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelVertical.ResumeLayout(false);
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblFiltroRap;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrecio;
    }
}

