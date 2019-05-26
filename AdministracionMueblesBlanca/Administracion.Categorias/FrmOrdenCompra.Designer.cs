namespace Administracion.Categorias
{
    partial class FrmOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrdenCompra = new System.Windows.Forms.DataGridView();
            this.dgvCodigoOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfirmarPago = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(300, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordenes de Compra";
            // 
            // dgvOrdenCompra
            // 
            this.dgvOrdenCompra.AllowUserToAddRows = false;
            this.dgvOrdenCompra.AllowUserToDeleteRows = false;
            this.dgvOrdenCompra.AllowUserToOrderColumns = true;
            this.dgvOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodigoOrden,
            this.dgvNroId,
            this.dgvNombre,
            this.dgvTotalOrden,
            this.dgvFechaOrden,
            this.dgvFechaPago});
            this.dgvOrdenCompra.Location = new System.Drawing.Point(12, 91);
            this.dgvOrdenCompra.Name = "dgvOrdenCompra";
            this.dgvOrdenCompra.ReadOnly = true;
            this.dgvOrdenCompra.Size = new System.Drawing.Size(776, 277);
            this.dgvOrdenCompra.TabIndex = 5;
            this.dgvOrdenCompra.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrdenCompra_CellFormatting);
            // 
            // dgvCodigoOrden
            // 
            this.dgvCodigoOrden.HeaderText = "Orden";
            this.dgvCodigoOrden.Name = "dgvCodigoOrden";
            this.dgvCodigoOrden.ReadOnly = true;
            this.dgvCodigoOrden.Width = 150;
            // 
            // dgvNroId
            // 
            this.dgvNroId.HeaderText = "Numero de Identificacion";
            this.dgvNroId.Name = "dgvNroId";
            this.dgvNroId.ReadOnly = true;
            this.dgvNroId.Width = 150;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre del Cliente";
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.ReadOnly = true;
            this.dgvNombre.Width = 200;
            // 
            // dgvTotalOrden
            // 
            this.dgvTotalOrden.HeaderText = "Total de la Orden";
            this.dgvTotalOrden.Name = "dgvTotalOrden";
            this.dgvTotalOrden.ReadOnly = true;
            this.dgvTotalOrden.Width = 150;
            // 
            // dgvFechaOrden
            // 
            this.dgvFechaOrden.HeaderText = "Fecha de Orden";
            this.dgvFechaOrden.Name = "dgvFechaOrden";
            this.dgvFechaOrden.ReadOnly = true;
            this.dgvFechaOrden.Width = 150;
            // 
            // dgvFechaPago
            // 
            this.dgvFechaPago.HeaderText = "Fecha de Pago";
            this.dgvFechaPago.Name = "dgvFechaPago";
            this.dgvFechaPago.ReadOnly = true;
            this.dgvFechaPago.Width = 150;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(380, 392);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnVerDetalle.TabIndex = 6;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(268, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfirmarPago
            // 
            this.btnConfirmarPago.Location = new System.Drawing.Point(488, 392);
            this.btnConfirmarPago.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarPago.Name = "btnConfirmarPago";
            this.btnConfirmarPago.Size = new System.Drawing.Size(100, 22);
            this.btnConfirmarPago.TabIndex = 8;
            this.btnConfirmarPago.Text = "Confirmar pago";
            this.btnConfirmarPago.UseVisualStyleBackColor = true;
            this.btnConfirmarPago.Click += new System.EventHandler(this.btnConfirmarPago_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            // FrmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnConfirmarPago);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.dgvOrdenCompra);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrdenCompra";
            this.Text = "FrmOrdenCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrdenCompra;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfirmarPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaPago;
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