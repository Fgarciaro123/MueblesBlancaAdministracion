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
            this.dgvNomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).BeginInit();
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
            this.dgvNomProducto,
            this.dgvTotalOrden,
            this.dgvFechaOrden,
            this.dgvFechaPago});
            this.dgvOrdenCompra.Location = new System.Drawing.Point(12, 91);
            this.dgvOrdenCompra.Name = "dgvOrdenCompra";
            this.dgvOrdenCompra.ReadOnly = true;
            this.dgvOrdenCompra.Size = new System.Drawing.Size(776, 277);
            this.dgvOrdenCompra.TabIndex = 5;
            // 
            // dgvCodigoOrden
            // 
            this.dgvCodigoOrden.HeaderText = "Orden";
            this.dgvCodigoOrden.Name = "dgvCodigoOrden";
            this.dgvCodigoOrden.ReadOnly = true;
            // 
            // dgvNroId
            // 
            this.dgvNroId.HeaderText = "Numero de Identificacion";
            this.dgvNroId.Name = "dgvNroId";
            this.dgvNroId.ReadOnly = true;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre del Cliente";
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.ReadOnly = true;
            // 
            // dgvNomProducto
            // 
            this.dgvNomProducto.HeaderText = "Producto";
            this.dgvNomProducto.Name = "dgvNomProducto";
            this.dgvNomProducto.ReadOnly = true;
            // 
            // dgvTotalOrden
            // 
            this.dgvTotalOrden.HeaderText = "Total de la Orden";
            this.dgvTotalOrden.Name = "dgvTotalOrden";
            this.dgvTotalOrden.ReadOnly = true;
            // 
            // dgvFechaOrden
            // 
            this.dgvFechaOrden.HeaderText = "Fecha de Orden";
            this.dgvFechaOrden.Name = "dgvFechaOrden";
            this.dgvFechaOrden.ReadOnly = true;
            // 
            // dgvFechaPago
            // 
            this.dgvFechaPago.HeaderText = "Fecha de Pago";
            this.dgvFechaPago.Name = "dgvFechaPago";
            this.dgvFechaPago.ReadOnly = true;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(430, 392);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnVerDetalle.TabIndex = 6;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(305, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigoOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotalOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaPago;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnSalir;
    }
}