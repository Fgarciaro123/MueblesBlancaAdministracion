namespace Administracion.Categorias
{
    partial class FrmCategorias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cmbEstadoCategoria = new System.Windows.Forms.ComboBox();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.lblEstadoCategoria = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.dgvIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstadoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaCreacionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarioCreacionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaModificacionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarioModificacionCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderCategorias = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDatos.SuspendLayout();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cmbEstadoCategoria);
            this.gbDatos.Controls.Add(this.txtNombreCategoria);
            this.gbDatos.Controls.Add(this.txtIdCategoria);
            this.gbDatos.Controls.Add(this.lblEstadoCategoria);
            this.gbDatos.Controls.Add(this.lblNombreCategoria);
            this.gbDatos.Controls.Add(this.lblIdCategoria);
            this.gbDatos.Location = new System.Drawing.Point(83, 37);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(537, 155);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            // 
            // cmbEstadoCategoria
            // 
            this.cmbEstadoCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCategoria.FormattingEnabled = true;
            this.cmbEstadoCategoria.Location = new System.Drawing.Point(178, 91);
            this.cmbEstadoCategoria.Name = "cmbEstadoCategoria";
            this.cmbEstadoCategoria.Size = new System.Drawing.Size(141, 21);
            this.cmbEstadoCategoria.TabIndex = 5;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(179, 64);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(264, 20);
            this.txtNombreCategoria.TabIndex = 4;
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(178, 32);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.ReadOnly = true;
            this.txtIdCategoria.Size = new System.Drawing.Size(141, 20);
            this.txtIdCategoria.TabIndex = 3;
            // 
            // lblEstadoCategoria
            // 
            this.lblEstadoCategoria.AutoSize = true;
            this.lblEstadoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCategoria.Location = new System.Drawing.Point(38, 93);
            this.lblEstadoCategoria.Name = "lblEstadoCategoria";
            this.lblEstadoCategoria.Size = new System.Drawing.Size(60, 20);
            this.lblEstadoCategoria.TabIndex = 2;
            this.lblEstadoCategoria.Text = "Estado";
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNombreCategoria.Location = new System.Drawing.Point(38, 62);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(68, 20);
            this.lblNombreCategoria.TabIndex = 1;
            this.lblNombreCategoria.Text = "Nombre";
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblIdCategoria.Location = new System.Drawing.Point(38, 30);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(61, 20);
            this.lblIdCategoria.TabIndex = 0;
            this.lblIdCategoria.Text = "Código";
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnSalir);
            this.gbControl.Controls.Add(this.btnEliminar);
            this.gbControl.Controls.Add(this.btnEditar);
            this.gbControl.Controls.Add(this.btnGrabar);
            this.gbControl.Controls.Add(this.btnNuevo);
            this.gbControl.Location = new System.Drawing.Point(662, 30);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(106, 177);
            this.gbControl.TabIndex = 1;
            this.gbControl.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(16, 139);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(16, 109);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(16, 79);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(16, 49);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(16, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AllowUserToOrderColumns = true;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdCategoria,
            this.dgvNombreCategoria,
            this.dgvEstadoCategoria,
            this.dgvFechaCreacionCategoria,
            this.dgvUsuarioCreacionCategoria,
            this.dgvFechaModificacionCategoria,
            this.dgvUsuarioModificacionCategoria});
            this.dgvCategoria.Location = new System.Drawing.Point(21, 213);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.Size = new System.Drawing.Size(794, 225);
            this.dgvCategoria.TabIndex = 2;
            // 
            // dgvIdCategoria
            // 
            this.dgvIdCategoria.HeaderText = "Código";
            this.dgvIdCategoria.Name = "dgvIdCategoria";
            this.dgvIdCategoria.ReadOnly = true;
            // 
            // dgvNombreCategoria
            // 
            this.dgvNombreCategoria.HeaderText = "Nombre";
            this.dgvNombreCategoria.Name = "dgvNombreCategoria";
            this.dgvNombreCategoria.ReadOnly = true;
            // 
            // dgvEstadoCategoria
            // 
            this.dgvEstadoCategoria.HeaderText = "Estado";
            this.dgvEstadoCategoria.Name = "dgvEstadoCategoria";
            this.dgvEstadoCategoria.ReadOnly = true;
            this.dgvEstadoCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvFechaCreacionCategoria
            // 
            this.dgvFechaCreacionCategoria.HeaderText = "Fecha Creación";
            this.dgvFechaCreacionCategoria.Name = "dgvFechaCreacionCategoria";
            this.dgvFechaCreacionCategoria.ReadOnly = true;
            // 
            // dgvUsuarioCreacionCategoria
            // 
            this.dgvUsuarioCreacionCategoria.HeaderText = "Usuario Creación";
            this.dgvUsuarioCreacionCategoria.Name = "dgvUsuarioCreacionCategoria";
            this.dgvUsuarioCreacionCategoria.ReadOnly = true;
            // 
            // dgvFechaModificacionCategoria
            // 
            this.dgvFechaModificacionCategoria.HeaderText = "Fecha Modificación";
            this.dgvFechaModificacionCategoria.Name = "dgvFechaModificacionCategoria";
            this.dgvFechaModificacionCategoria.ReadOnly = true;
            // 
            // dgvUsuarioModificacionCategoria
            // 
            this.dgvUsuarioModificacionCategoria.HeaderText = "Usuario Modificación";
            this.dgvUsuarioModificacionCategoria.Name = "dgvUsuarioModificacionCategoria";
            this.dgvUsuarioModificacionCategoria.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(290, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Módulo de Categorias";
            // 
            // errorProviderCategorias
            // 
            this.errorProviderCategorias.ContainerControl = this;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(827, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.Label lblEstadoCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.ComboBox cmbEstadoCategoria;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstadoCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaCreacionCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarioCreacionCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaModificacionCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarioModificacionCategoria;
    }
}

