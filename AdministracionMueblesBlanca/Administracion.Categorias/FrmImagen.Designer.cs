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
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(305, 79);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(593, 319);
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(453, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 30);
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
            this.dataGridView1.Location = new System.Drawing.Point(16, 417);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1127, 199);
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
            this.btnEliminar.Location = new System.Drawing.Point(960, 128);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 28);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(960, 201);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(124, 28);
            this.btnCargarImagen.TabIndex = 7;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(456, 79);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(0, 17);
            this.lblNombreProducto.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(960, 265);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 28);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1159, 636);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImagen";
            this.Text = "Gestion Imagenes";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}