namespace Administracion.Categorias
{
    partial class FrmRoles
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cmbEstadoRol = new System.Windows.Forms.ComboBox();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.lblEstadoRol = new System.Windows.Forms.Label();
            this.lblNombreRol = new System.Windows.Forms.Label();
            this.lblIdRol = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRol = new System.Windows.Forms.DataGridView();
            this.dgvIdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombreRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstadoRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaCreacionRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarioCreacionRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaModificacionRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarioModificacionRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cmbEstadoRol);
            this.gbDatos.Controls.Add(this.txtNombreRol);
            this.gbDatos.Controls.Add(this.txtIdRol);
            this.gbDatos.Controls.Add(this.lblEstadoRol);
            this.gbDatos.Controls.Add(this.lblNombreRol);
            this.gbDatos.Controls.Add(this.lblIdRol);
            this.gbDatos.Location = new System.Drawing.Point(72, 61);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(476, 147);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            // 
            // cmbEstadoRol
            // 
            this.cmbEstadoRol.FormattingEnabled = true;
            this.cmbEstadoRol.Location = new System.Drawing.Point(178, 103);
            this.cmbEstadoRol.Name = "cmbEstadoRol";
            this.cmbEstadoRol.Size = new System.Drawing.Size(188, 21);
            this.cmbEstadoRol.TabIndex = 5;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(178, 72);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(247, 20);
            this.txtNombreRol.TabIndex = 4;
            // 
            // txtIdRol
            // 
            this.txtIdRol.Location = new System.Drawing.Point(178, 36);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.ReadOnly = true;
            this.txtIdRol.Size = new System.Drawing.Size(188, 20);
            this.txtIdRol.TabIndex = 3;
            // 
            // lblEstadoRol
            // 
            this.lblEstadoRol.AutoSize = true;
            this.lblEstadoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoRol.Location = new System.Drawing.Point(40, 101);
            this.lblEstadoRol.Name = "lblEstadoRol";
            this.lblEstadoRol.Size = new System.Drawing.Size(60, 20);
            this.lblEstadoRol.TabIndex = 2;
            this.lblEstadoRol.Text = "Estado";
            // 
            // lblNombreRol
            // 
            this.lblNombreRol.AutoSize = true;
            this.lblNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRol.Location = new System.Drawing.Point(40, 70);
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(65, 20);
            this.lblNombreRol.TabIndex = 1;
            this.lblNombreRol.Text = "Nombre";
            // 
            // lblIdRol
            // 
            this.lblIdRol.AutoSize = true;
            this.lblIdRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRol.Location = new System.Drawing.Point(40, 36);
            this.lblIdRol.Name = "lblIdRol";
            this.lblIdRol.Size = new System.Drawing.Size(59, 20);
            this.lblIdRol.TabIndex = 0;
            this.lblIdRol.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnGrabar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(586, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(32, 138);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(32, 108);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(32, 78);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(32, 49);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(32, 20);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(303, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modulo de Roles";
            // 
            // dgvRol
            // 
            this.dgvRol.AllowUserToAddRows = false;
            this.dgvRol.AllowUserToDeleteRows = false;
            this.dgvRol.AllowUserToOrderColumns = true;
            this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIdRol,
            this.dgvNombreRol,
            this.dgvEstadoRol,
            this.dgvFechaCreacionRol,
            this.dgvUsuarioCreacionRol,
            this.dgvFechaModificacionRol,
            this.dgvUsuarioModificacionRol});
            this.dgvRol.Location = new System.Drawing.Point(39, 242);
            this.dgvRol.Name = "dgvRol";
            this.dgvRol.ReadOnly = true;
            this.dgvRol.Size = new System.Drawing.Size(761, 176);
            this.dgvRol.TabIndex = 3;
            // 
            // dgvIdRol
            // 
            this.dgvIdRol.HeaderText = "Codigo";
            this.dgvIdRol.Name = "dgvIdRol";
            this.dgvIdRol.ReadOnly = true;
            // 
            // dgvNombreRol
            // 
            this.dgvNombreRol.HeaderText = "Nombre";
            this.dgvNombreRol.Name = "dgvNombreRol";
            this.dgvNombreRol.ReadOnly = true;
            // 
            // dgvEstadoRol
            // 
            this.dgvEstadoRol.HeaderText = "Estado";
            this.dgvEstadoRol.Name = "dgvEstadoRol";
            this.dgvEstadoRol.ReadOnly = true;
            this.dgvEstadoRol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvFechaCreacionRol
            // 
            this.dgvFechaCreacionRol.HeaderText = "Fecha Creacion";
            this.dgvFechaCreacionRol.Name = "dgvFechaCreacionRol";
            this.dgvFechaCreacionRol.ReadOnly = true;
            // 
            // dgvUsuarioCreacionRol
            // 
            this.dgvUsuarioCreacionRol.HeaderText = "Usuario Creacion";
            this.dgvUsuarioCreacionRol.Name = "dgvUsuarioCreacionRol";
            this.dgvUsuarioCreacionRol.ReadOnly = true;
            // 
            // dgvFechaModificacionRol
            // 
            this.dgvFechaModificacionRol.HeaderText = "Fecha Modificacion";
            this.dgvFechaModificacionRol.Name = "dgvFechaModificacionRol";
            this.dgvFechaModificacionRol.ReadOnly = true;
            // 
            // dgvUsuarioModificacionRol
            // 
            this.dgvUsuarioModificacionRol.HeaderText = "Usuario Modificacion";
            this.dgvUsuarioModificacionRol.Name = "dgvUsuarioModificacionRol";
            this.dgvUsuarioModificacionRol.ReadOnly = true;
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.dgvRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbDatos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.FrmRoles_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblEstadoRol;
        private System.Windows.Forms.Label lblNombreRol;
        private System.Windows.Forms.Label lblIdRol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdRol;
        private System.Windows.Forms.ComboBox cmbEstadoRol;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombreRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstadoRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaCreacionRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarioCreacionRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaModificacionRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarioModificacionRol;
    }
}