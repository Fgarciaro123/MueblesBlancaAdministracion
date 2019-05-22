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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoDocumento));
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cmbEstadoTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtDescripcionTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtIdTipoDocumento = new System.Windows.Forms.TextBox();
            this.lblEstadoTipoDocumento = new System.Windows.Forms.Label();
            this.lblDescripcionTipoDocumento = new System.Windows.Forms.Label();
            this.lblIdTipoDocumento = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(317, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Módulo de Tipos de Documento";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cmbEstadoTipoDocumento);
            this.gbDatos.Controls.Add(this.txtDescripcionTipoDocumento);
            this.gbDatos.Controls.Add(this.txtIdTipoDocumento);
            this.gbDatos.Controls.Add(this.lblEstadoTipoDocumento);
            this.gbDatos.Controls.Add(this.lblDescripcionTipoDocumento);
            this.gbDatos.Controls.Add(this.lblIdTipoDocumento);
            this.gbDatos.Location = new System.Drawing.Point(73, 95);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatos.Size = new System.Drawing.Size(667, 193);
            this.gbDatos.TabIndex = 5;
            this.gbDatos.TabStop = false;
            // 
            // cmbEstadoTipoDocumento
            // 
            this.cmbEstadoTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoTipoDocumento.FormattingEnabled = true;
            this.cmbEstadoTipoDocumento.Location = new System.Drawing.Point(239, 134);
            this.cmbEstadoTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstadoTipoDocumento.Name = "cmbEstadoTipoDocumento";
            this.cmbEstadoTipoDocumento.Size = new System.Drawing.Size(243, 24);
            this.cmbEstadoTipoDocumento.TabIndex = 5;
            // 
            // txtDescripcionTipoDocumento
            // 
            this.txtDescripcionTipoDocumento.Location = new System.Drawing.Point(239, 84);
            this.txtDescripcionTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionTipoDocumento.MaxLength = 200;
            this.txtDescripcionTipoDocumento.Name = "txtDescripcionTipoDocumento";
            this.txtDescripcionTipoDocumento.Size = new System.Drawing.Size(333, 22);
            this.txtDescripcionTipoDocumento.TabIndex = 4;
            // 
            // txtIdTipoDocumento
            // 
            this.txtIdTipoDocumento.Location = new System.Drawing.Point(239, 34);
            this.txtIdTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdTipoDocumento.Name = "txtIdTipoDocumento";
            this.txtIdTipoDocumento.ReadOnly = true;
            this.txtIdTipoDocumento.Size = new System.Drawing.Size(243, 22);
            this.txtIdTipoDocumento.TabIndex = 3;
            // 
            // lblEstadoTipoDocumento
            // 
            this.lblEstadoTipoDocumento.AutoSize = true;
            this.lblEstadoTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoTipoDocumento.Location = new System.Drawing.Point(49, 134);
            this.lblEstadoTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoTipoDocumento.Name = "lblEstadoTipoDocumento";
            this.lblEstadoTipoDocumento.Size = new System.Drawing.Size(73, 25);
            this.lblEstadoTipoDocumento.TabIndex = 2;
            this.lblEstadoTipoDocumento.Text = "Estado";
            // 
            // lblDescripcionTipoDocumento
            // 
            this.lblDescripcionTipoDocumento.AutoSize = true;
            this.lblDescripcionTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionTipoDocumento.Location = new System.Drawing.Point(49, 85);
            this.lblDescripcionTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionTipoDocumento.Name = "lblDescripcionTipoDocumento";
            this.lblDescripcionTipoDocumento.Size = new System.Drawing.Size(114, 25);
            this.lblDescripcionTipoDocumento.TabIndex = 1;
            this.lblDescripcionTipoDocumento.Text = "Descripción";
            // 
            // lblIdTipoDocumento
            // 
            this.lblIdTipoDocumento.AutoSize = true;
            this.lblIdTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTipoDocumento.Location = new System.Drawing.Point(49, 36);
            this.lblIdTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdTipoDocumento.Name = "lblIdTipoDocumento";
            this.lblIdTipoDocumento.Size = new System.Drawing.Size(75, 25);
            this.lblIdTipoDocumento.TabIndex = 0;
            this.lblIdTipoDocumento.Text = "Código";
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnSalir);
            this.gbControl.Controls.Add(this.btnEliminar);
            this.gbControl.Controls.Add(this.btnEditar);
            this.gbControl.Controls.Add(this.btnGrabar);
            this.gbControl.Controls.Add(this.btnNuevo);
            this.gbControl.Location = new System.Drawing.Point(797, 82);
            this.gbControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbControl.Name = "gbControl";
            this.gbControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbControl.Size = new System.Drawing.Size(188, 222);
            this.gbControl.TabIndex = 6;
            this.gbControl.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(48, 171);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(48, 134);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(48, 97);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 28);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(48, 60);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 28);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(48, 23);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 28);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.dgvTipoDocumento.Location = new System.Drawing.Point(40, 310);
            this.dgvTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTipoDocumento.Name = "dgvTipoDocumento";
            this.dgvTipoDocumento.ReadOnly = true;
            this.dgvTipoDocumento.Size = new System.Drawing.Size(997, 229);
            this.dgvTipoDocumento.TabIndex = 7;
            // 
            // dgvIdTipoDocumento
            // 
            this.dgvIdTipoDocumento.HeaderText = "Código";
            this.dgvIdTipoDocumento.Name = "dgvIdTipoDocumento";
            this.dgvIdTipoDocumento.ReadOnly = true;
            // 
            // dgvDescripcionTipoDocumento
            // 
            this.dgvDescripcionTipoDocumento.HeaderText = "Descripción";
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
            this.dgvFechaCreacionTipoDocumento.HeaderText = "Fecha Creación";
            this.dgvFechaCreacionTipoDocumento.Name = "dgvFechaCreacionTipoDocumento";
            this.dgvFechaCreacionTipoDocumento.ReadOnly = true;
            // 
            // dgvUsuarioCreacionTipoDocumento
            // 
            this.dgvUsuarioCreacionTipoDocumento.HeaderText = "Usuario Creación";
            this.dgvUsuarioCreacionTipoDocumento.Name = "dgvUsuarioCreacionTipoDocumento";
            this.dgvUsuarioCreacionTipoDocumento.ReadOnly = true;
            // 
            // dgvFechaModificacionTipoDocumento
            // 
            this.dgvFechaModificacionTipoDocumento.HeaderText = "Fecha Modificación";
            this.dgvFechaModificacionTipoDocumento.Name = "dgvFechaModificacionTipoDocumento";
            this.dgvFechaModificacionTipoDocumento.ReadOnly = true;
            // 
            // dgvUsuarioModificacionTipoDocumento
            // 
            this.dgvUsuarioModificacionTipoDocumento.HeaderText = "Usuario Modificación";
            this.dgvUsuarioModificacionTipoDocumento.Name = "dgvUsuarioModificacionTipoDocumento";
            this.dgvUsuarioModificacionTipoDocumento.ReadOnly = true;
            // 
            // FrmTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.dgvTipoDocumento);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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