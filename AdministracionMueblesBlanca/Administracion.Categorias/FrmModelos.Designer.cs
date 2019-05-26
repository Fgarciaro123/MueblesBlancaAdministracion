﻿namespace Administracion.Categorias
{
    partial class FrmModelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModelos));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.cmbEstadoModelo = new System.Windows.Forms.ComboBox();
            this.txtRutaModelo = new System.Windows.Forms.TextBox();
            this.txtTituloModelo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTituloModelo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTituloModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRutaModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEstadoModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarioCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarioModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatos.SuspendLayout();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnExaminar);
            this.gbDatos.Controls.Add(this.cmbEstadoModelo);
            this.gbDatos.Controls.Add(this.txtRutaModelo);
            this.gbDatos.Controls.Add(this.txtTituloModelo);
            this.gbDatos.Controls.Add(this.txtCodigo);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.lblRuta);
            this.gbDatos.Controls.Add(this.lblTitulo);
            this.gbDatos.Controls.Add(this.lblTituloModelo);
            this.gbDatos.Location = new System.Drawing.Point(131, 76);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatos.Size = new System.Drawing.Size(781, 209);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(615, 121);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(137, 28);
            this.btnExaminar.TabIndex = 9;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // cmbEstadoModelo
            // 
            this.cmbEstadoModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoModelo.FormattingEnabled = true;
            this.cmbEstadoModelo.Location = new System.Drawing.Point(137, 156);
            this.cmbEstadoModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstadoModelo.Name = "cmbEstadoModelo";
            this.cmbEstadoModelo.Size = new System.Drawing.Size(203, 24);
            this.cmbEstadoModelo.TabIndex = 8;
            // 
            // txtRutaModelo
            // 
            this.txtRutaModelo.Location = new System.Drawing.Point(137, 123);
            this.txtRutaModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRutaModelo.MaxLength = 250;
            this.txtRutaModelo.Name = "txtRutaModelo";
            this.txtRutaModelo.ReadOnly = true;
            this.txtRutaModelo.Size = new System.Drawing.Size(448, 22);
            this.txtRutaModelo.TabIndex = 7;
            // 
            // txtTituloModelo
            // 
            this.txtTituloModelo.Location = new System.Drawing.Point(137, 80);
            this.txtTituloModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTituloModelo.MaxLength = 100;
            this.txtTituloModelo.Name = "txtTituloModelo";
            this.txtTituloModelo.Size = new System.Drawing.Size(448, 22);
            this.txtTituloModelo.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(137, 41);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(203, 22);
            this.txtCodigo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(23, 119);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(48, 24);
            this.lblRuta.TabIndex = 3;
            this.lblRuta.Text = "Ruta";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(23, 80);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(56, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título";
            // 
            // lblTituloModelo
            // 
            this.lblTituloModelo.AutoSize = true;
            this.lblTituloModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModelo.Location = new System.Drawing.Point(23, 39);
            this.lblTituloModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloModelo.Name = "lblTituloModelo";
            this.lblTituloModelo.Size = new System.Drawing.Size(71, 24);
            this.lblTituloModelo.TabIndex = 1;
            this.lblTituloModelo.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(487, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gestionar Modelos";
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btnSalir);
            this.gbControl.Controls.Add(this.btnEliminar);
            this.gbControl.Controls.Add(this.btnEditar);
            this.gbControl.Controls.Add(this.btnGrabar);
            this.gbControl.Controls.Add(this.btnNuevo);
            this.gbControl.Location = new System.Drawing.Point(964, 76);
            this.gbControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbControl.Name = "gbControl";
            this.gbControl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbControl.Size = new System.Drawing.Size(185, 209);
            this.gbControl.TabIndex = 5;
            this.gbControl.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(43, 165);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(43, 128);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(43, 91);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 28);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(43, 54);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 28);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(43, 17);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 28);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodigo,
            this.dgvTituloModelo,
            this.dgvRutaModelo,
            this.dgvEstadoModelo,
            this.dgvFechaCreacion,
            this.dgvUsuarioCreacion,
            this.dgvFechaModificacion,
            this.dgvUsuarioModificacion});
            this.dataGridView1.Location = new System.Drawing.Point(35, 304);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 235);
            this.dataGridView1.TabIndex = 6;
            // 
            // dgvCodigo
            // 
            this.dgvCodigo.HeaderText = "Código";
            this.dgvCodigo.Name = "dgvCodigo";
            this.dgvCodigo.ReadOnly = true;
            // 
            // dgvTituloModelo
            // 
            this.dgvTituloModelo.HeaderText = "Título";
            this.dgvTituloModelo.Name = "dgvTituloModelo";
            this.dgvTituloModelo.ReadOnly = true;
            // 
            // dgvRutaModelo
            // 
            this.dgvRutaModelo.HeaderText = "Ruta ";
            this.dgvRutaModelo.Name = "dgvRutaModelo";
            this.dgvRutaModelo.ReadOnly = true;
            // 
            // dgvEstadoModelo
            // 
            this.dgvEstadoModelo.HeaderText = "Estado ";
            this.dgvEstadoModelo.Name = "dgvEstadoModelo";
            this.dgvEstadoModelo.ReadOnly = true;
            // 
            // dgvFechaCreacion
            // 
            this.dgvFechaCreacion.HeaderText = "Fecha Creación";
            this.dgvFechaCreacion.Name = "dgvFechaCreacion";
            this.dgvFechaCreacion.ReadOnly = true;
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
            // FrmModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1204, 554);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModelos";
            this.Text = "Gestion Modelos";
            this.Load += new System.EventHandler(this.FrmModelos_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloModelo;
        private System.Windows.Forms.ComboBox cmbEstadoModelo;
        private System.Windows.Forms.TextBox txtRutaModelo;
        private System.Windows.Forms.TextBox txtTituloModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTituloModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRutaModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEstadoModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarioCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFechaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsuarioModificacion;
    }
}