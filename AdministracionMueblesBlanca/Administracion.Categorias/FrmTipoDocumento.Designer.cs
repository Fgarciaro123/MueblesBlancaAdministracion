namespace Administracion.Categorias
{
    partial class FrmTipoDocumento
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
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblIdTipoDocumento = new System.Windows.Forms.Label();
            this.lblDescripcionTipoDocumento = new System.Windows.Forms.Label();
            this.lblEstadoTipoDocumento = new System.Windows.Forms.Label();
            this.txtIdTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtDescripcionTipoDocumento = new System.Windows.Forms.TextBox();
            this.cmbEstadoTipoDocumento = new System.Windows.Forms.ComboBox();
            this.dgvTipoDocumento = new System.Windows.Forms.DataGridView();
            this.dgvIdTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescripcionTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstadoTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaCreacionTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarioCreacionTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaModificacionTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarioModificacionTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatos.SuspendLayout();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(238, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modulo de Tipos de Documento";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cmbEstadoTipoDocumento);
            this.gbDatos.Controls.Add(this.txtDescripcionTipoDocumento);
            this.gbDatos.Controls.Add(this.txtIdTipoDocumento);
            this.gbDatos.Controls.Add(this.lblEstadoTipoDocumento);
            this.gbDatos.Controls.Add(this.lblDescripcionTipoDocumento);
            this.gbDatos.Controls.Add(this.lblIdTipoDocumento);
            this.gbDatos.Location = new System.Drawing.Point(55, 77);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(500, 157);
            this.gbDatos.TabIndex = 5;
            this.gbDatos.TabStop = false;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnSalir);
            this.gbControl.Controls.Add(this.btnEliminar);
            this.gbControl.Controls.Add(this.btnEditar);
            this.gbControl.Controls.Add(this.btnGrabar);
            this.gbControl.Controls.Add(this.btnNuevo);
            this.gbControl.Location = new System.Drawing.Point(598, 67);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(141, 180);
            this.gbControl.TabIndex = 6;
            this.gbControl.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(36, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(36, 49);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);

            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(36, 79);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(36, 109);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(36, 139);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // 
            // lblIdTipoDocumento
            // 
            this.lblIdTipoDocumento.AutoSize = true;
            this.lblIdTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTipoDocumento.Location = new System.Drawing.Point(37, 29);
            this.lblIdTipoDocumento.Name = "lblIdTipoDocumento";
            this.lblIdTipoDocumento.Size = new System.Drawing.Size(59, 20);
            this.lblIdTipoDocumento.TabIndex = 0;
            this.lblIdTipoDocumento.Text = "Codigo";
            // 
            // lblDescripcionTipoDocumento
            // 
            this.lblDescripcionTipoDocumento.AutoSize = true;
            this.lblDescripcionTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionTipoDocumento.Location = new System.Drawing.Point(37, 69);
            this.lblDescripcionTipoDocumento.Name = "lblDescripcionTipoDocumento";
            this.lblDescripcionTipoDocumento.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcionTipoDocumento.TabIndex = 1;
            this.lblDescripcionTipoDocumento.Text = "Descripcion";
            // 
            // lblEstadoTipoDocumento
            // 
            this.lblEstadoTipoDocumento.AutoSize = true;
            this.lblEstadoTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoTipoDocumento.Location = new System.Drawing.Point(37, 109);
            this.lblEstadoTipoDocumento.Name = "lblEstadoTipoDocumento";
            this.lblEstadoTipoDocumento.Size = new System.Drawing.Size(60, 20);
            this.lblEstadoTipoDocumento.TabIndex = 2;
            this.lblEstadoTipoDocumento.Text = "Estado";
            // 
            // txtIdTipoDocumento
            // 
            this.txtIdTipoDocumento.Location = new System.Drawing.Point(179, 28);
            this.txtIdTipoDocumento.Name = "txtIdTipoDocumento";
            this.txtIdTipoDocumento.ReadOnly = true;
            this.txtIdTipoDocumento.Size = new System.Drawing.Size(183, 20);
            this.txtIdTipoDocumento.TabIndex = 3;
            // 
            // txtDescripcionTipoDocumento
            // 
            this.txtDescripcionTipoDocumento.Location = new System.Drawing.Point(179, 68);
            this.txtDescripcionTipoDocumento.Name = "txtDescripcionTipoDocumento";
            this.txtDescripcionTipoDocumento.Size = new System.Drawing.Size(251, 20);
            this.txtDescripcionTipoDocumento.TabIndex = 4;
            // 
            // cmbEstadoTipoDocumento
            // 
            this.cmbEstadoTipoDocumento.FormattingEnabled = true;
            this.cmbEstadoTipoDocumento.Location = new System.Drawing.Point(179, 109);
            this.cmbEstadoTipoDocumento.Name = "cmbEstadoTipoDocumento";
            this.cmbEstadoTipoDocumento.Size = new System.Drawing.Size(183, 21);
            this.cmbEstadoTipoDocumento.TabIndex = 5;
            // 
            // dgvTipoDocumento
            // 
            this.dgvTipoDocumento.AllowUserToAddRows = false;
            this.dgvTipoDocumento.AllowUserToDeleteRows = false;
            this.dgvTipoDocumento.AllowUserToOrderColumns = true;
            this.dgvTipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoDocumento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdTipoDocumento,
            this.dgvDescripcionTipoDocumento,
            this.dgvEstadoTipoDocumento,
            this.dgvFechaCreacionTipoDocumento,
            this.dgvUsuarioCreacionTipoDocumento,
            this.dgvFechaModificacionTipoDocumento,
            this.dgvUsuarioModificacionTipoDocumento});
            this.dgvTipoDocumento.Location = new System.Drawing.Point(30, 252);
            this.dgvTipoDocumento.Name = "dgvTipoDocumento";
            this.dgvTipoDocumento.ReadOnly = true;
            this.dgvTipoDocumento.Size = new System.Drawing.Size(748, 186);
            this.dgvTipoDocumento.TabIndex = 7;
            // 
            // dgvIdTipoDocumento
            // 
            this.dgvIdTipoDocumento.HeaderText = "Codigo";
            this.dgvIdTipoDocumento.Name = "dgvIdTipoDocumento";
            this.dgvIdTipoDocumento.ReadOnly = true;
            // 
            // dgvDescripcionTipoDocumento
            // 
            this.dgvDescripcionTipoDocumento.HeaderText = "Descripcion";
            this.dgvDescripcionTipoDocumento.Name = "dgvDescripcionTipoDocumento";
            this.dgvDescripcionTipoDocumento.ReadOnly = true;
            // 
            // dgvEstadoTipoDocumento
            // 
            this.dgvEstadoTipoDocumento.HeaderText = "Estado ";
            this.dgvEstadoTipoDocumento.Name = "dgvEstadoTipoDocumento";
            this.dgvEstadoTipoDocumento.ReadOnly = true;
            // 
            // dgvFechaCreacionTipoDocumento
            // 
            this.dgvFechaCreacionTipoDocumento.HeaderText = "Fecha Creacion";
            this.dgvFechaCreacionTipoDocumento.Name = "dgvFechaCreacionTipoDocumento";
            this.dgvFechaCreacionTipoDocumento.ReadOnly = true;
            // 
            // dgvUsuarioCreacionTipoDocumento
            // 
            this.dgvUsuarioCreacionTipoDocumento.HeaderText = "Usuario Creacion";
            this.dgvUsuarioCreacionTipoDocumento.Name = "dgvUsuarioCreacionTipoDocumento";
            this.dgvUsuarioCreacionTipoDocumento.ReadOnly = true;
            // 
            // dgvFechaModificacionTipoDocumento
            // 
            this.dgvFechaModificacionTipoDocumento.HeaderText = "Fecha Modificacion";
            this.dgvFechaModificacionTipoDocumento.Name = "dgvFechaModificacionTipoDocumento";
            this.dgvFechaModificacionTipoDocumento.ReadOnly = true;
            // 
            // dgvUsuarioModificacionTipoDocumento
            // 
            this.dgvUsuarioModificacionTipoDocumento.HeaderText = "Usuario Modificacion";
            this.dgvUsuarioModificacionTipoDocumento.Name = "dgvUsuarioModificacionTipoDocumento";
            this.dgvUsuarioModificacionTipoDocumento.ReadOnly = true;
            // 
            // FrmTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTipoDocumento);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipoDocumento";
            this.Text = "Tipo de Documento";
            this.Load += new System.EventHandler(this.FrmTipoDocumento_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDocumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblEstadoTipoDocumento;
        private System.Windows.Forms.Label lblDescripcionTipoDocumento;
        private System.Windows.Forms.Label lblIdTipoDocumento;
        private System.Windows.Forms.TextBox txtIdTipoDocumento;
        private System.Windows.Forms.ComboBox cmbEstadoTipoDocumento;
        private System.Windows.Forms.TextBox txtDescripcionTipoDocumento;
        private System.Windows.Forms.DataGridView dgvTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcionTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstadoTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaCreacionTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarioCreacionTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaModificacionTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarioModificacionTipoDocumento;
    }
}