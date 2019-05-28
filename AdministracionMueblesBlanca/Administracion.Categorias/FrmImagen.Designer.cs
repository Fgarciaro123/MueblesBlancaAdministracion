namespace Administracion.Categorias
{
    partial class FrmImagen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImagen));
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvCodigoImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTituloImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstadoImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaCreacionImagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarioCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarioModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionOrdenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(229, 64);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(445, 259);
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(340, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gestionar Imagenes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodigoImagen,
            this.dgvTituloImagen,
            this.dgvCodImagen,
            this.dgvEstadoImagen,
            this.dgvFechaCreacionImagen,
            this.dgvUsuarioCreacion,
            this.dgvFechaModificacion,
            this.dgvUsuarioModificacion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 162);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dgvCodigoImagen
            // 
            this.dgvCodigoImagen.HeaderText = "Código";
            this.dgvCodigoImagen.Name = "dgvCodigoImagen";
            this.dgvCodigoImagen.ReadOnly = true;
            // 
            // dgvTituloImagen
            // 
            this.dgvTituloImagen.HeaderText = "Titulo";
            this.dgvTituloImagen.Name = "dgvTituloImagen";
            this.dgvTituloImagen.ReadOnly = true;
            // 
            // dgvCodImagen
            // 
            this.dgvCodImagen.HeaderText = "Codigo";
            this.dgvCodImagen.Name = "dgvCodImagen";
            this.dgvCodImagen.ReadOnly = true;
            this.dgvCodImagen.Visible = false;
            // 
            // dgvEstadoImagen
            // 
            this.dgvEstadoImagen.HeaderText = "Estado";
            this.dgvEstadoImagen.Name = "dgvEstadoImagen";
            this.dgvEstadoImagen.ReadOnly = true;
            // 
            // dgvFechaCreacionImagen
            // 
            this.dgvFechaCreacionImagen.HeaderText = "Fecha Creación";
            this.dgvFechaCreacionImagen.Name = "dgvFechaCreacionImagen";
            this.dgvFechaCreacionImagen.ReadOnly = true;
            // 
            // dgvUsuarioCreacion
            // 
            this.dgvUsuarioCreacion.HeaderText = "Usuario Creación";
            this.dgvUsuarioCreacion.Name = "dgvUsuarioCreacion";
            this.dgvUsuarioCreacion.ReadOnly = true;
            // 
            // dgvFechaModificacion
            // 
            this.dgvFechaModificacion.HeaderText = "Fecha Modificación";
            this.dgvFechaModificacion.Name = "dgvFechaModificacion";
            this.dgvFechaModificacion.ReadOnly = true;
            // 
            // dgvUsuarioModificacion
            // 
            this.dgvUsuarioModificacion.HeaderText = "Usuario Modificación";
            this.dgvUsuarioModificacion.Name = "dgvUsuarioModificacion";
            this.dgvUsuarioModificacion.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(720, 104);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(720, 163);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(93, 23);
            this.btnCargarImagen.TabIndex = 7;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(342, 64);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(0, 13);
            this.lblNombreProducto.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(720, 215);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarClaveToolStripMenuItem,
            this.administracionToolStripMenuItem,
            this.cambioDeClaveToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.cambiarClaveToolStripMenuItem.Text = "Inicio";
            this.cambiarClaveToolStripMenuItem.Click += new System.EventHandler(this.cambiarClaveToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.tiposDeDocumentoToolStripMenuItem,
            this.administracionOrdenesDeCompraToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // tiposDeDocumentoToolStripMenuItem
            // 
            this.tiposDeDocumentoToolStripMenuItem.Name = "tiposDeDocumentoToolStripMenuItem";
            this.tiposDeDocumentoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.tiposDeDocumentoToolStripMenuItem.Text = "Tipos de Documento";
            this.tiposDeDocumentoToolStripMenuItem.Click += new System.EventHandler(this.tiposDeDocumentoToolStripMenuItem_Click);
            // 
            // administracionOrdenesDeCompraToolStripMenuItem
            // 
            this.administracionOrdenesDeCompraToolStripMenuItem.Name = "administracionOrdenesDeCompraToolStripMenuItem";
            this.administracionOrdenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.administracionOrdenesDeCompraToolStripMenuItem.Text = "Ordenes de Compra";
            this.administracionOrdenesDeCompraToolStripMenuItem.Click += new System.EventHandler(this.administracionOrdenesDeCompraToolStripMenuItem_Click);
            // 
            // cambioDeClaveToolStripMenuItem
            // 
            this.cambioDeClaveToolStripMenuItem.Name = "cambioDeClaveToolStripMenuItem";
            this.cambioDeClaveToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.cambioDeClaveToolStripMenuItem.Text = "Cambio de Clave";
            this.cambioDeClaveToolStripMenuItem.Click += new System.EventHandler(this.cambioDeClaveToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(869, 517);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImagen";
            this.Text = "Gestion Imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTituloImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstadoImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaCreacionImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarioCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarioModificacion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionOrdenesDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}