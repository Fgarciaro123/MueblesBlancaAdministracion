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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(400, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 30);
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
            this.dgvOrdenCompra.Location = new System.Drawing.Point(16, 112);
            this.dgvOrdenCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrdenCompra.Name = "dgvOrdenCompra";
            this.dgvOrdenCompra.ReadOnly = true;
            this.dgvOrdenCompra.Size = new System.Drawing.Size(1035, 341);
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
            this.btnVerDetalle.Location = new System.Drawing.Point(507, 483);
            this.btnVerDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(100, 28);
            this.btnVerDetalle.TabIndex = 6;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(357, 483);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfirmarPago
            // 
            this.btnConfirmarPago.Location = new System.Drawing.Point(650, 483);
            this.btnConfirmarPago.Name = "btnConfirmarPago";
            this.btnConfirmarPago.Size = new System.Drawing.Size(133, 27);
            this.btnConfirmarPago.TabIndex = 8;
            this.btnConfirmarPago.Text = "Confirmar pago";
            this.btnConfirmarPago.UseVisualStyleBackColor = true;
            this.btnConfirmarPago.Click += new System.EventHandler(this.btnConfirmarPago_Click);
            // 
            // FrmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnConfirmarPago);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.dgvOrdenCompra);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrdenCompra";
            this.Text = "Órdenes de compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).EndInit();
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
    }
}