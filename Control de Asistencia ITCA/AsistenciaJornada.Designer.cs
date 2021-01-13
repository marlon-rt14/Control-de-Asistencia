
namespace Control_de_Asistencia_ITCA
{
    partial class AsistenciaJornada
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
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tblRegistro = new System.Windows.Forms.DataGridView();
            this.txtUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Items.AddRange(new object[] {
            "Cambiar nombre de usuario",
            "Cambiar contraseña"});
            this.cmbUserName.Location = new System.Drawing.Point(150, 13);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(121, 21);
            this.cmbUserName.TabIndex = 16;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(713, 114);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 15;
            this.btnRefrescar.Text = "Recargar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(150, 114);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 23);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar Asistencia";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbxLogo.Location = new System.Drawing.Point(665, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(123, 96);
            this.pbxLogo.TabIndex = 13;
            this.pbxLogo.TabStop = false;
            // 
            // tblRegistro
            // 
            this.tblRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tblRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtUsuario,
            this.txtCedula,
            this.txtDescripcion,
            this.txtFecha,
            this.txtEstado,
            this.txtObservaciones,
            this.txtComentarios});
            this.tblRegistro.Location = new System.Drawing.Point(12, 143);
            this.tblRegistro.Name = "tblRegistro";
            this.tblRegistro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tblRegistro.Size = new System.Drawing.Size(776, 295);
            this.tblRegistro.TabIndex = 12;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtUsuario.FillWeight = 29.6085F;
            this.txtUsuario.HeaderText = "Usuario";
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            // 
            // txtCedula
            // 
            this.txtCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtCedula.FillWeight = 29.6085F;
            this.txtCedula.HeaderText = "Cédula";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtDescripcion.FillWeight = 532.9954F;
            this.txtDescripcion.HeaderText = "Descripción";
            this.txtDescripcion.MinimumWidth = 150;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtFecha.FillWeight = 29.6085F;
            this.txtFecha.HeaderText = "Fecha";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtEstado.FillWeight = 29.6085F;
            this.txtEstado.HeaderText = "Estado";
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtObservaciones.FillWeight = 29.6085F;
            this.txtObservaciones.HeaderText = "Observaciones";
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            // 
            // txtComentarios
            // 
            this.txtComentarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtComentarios.FillWeight = 29.6085F;
            this.txtComentarios.HeaderText = "Comentarios";
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.ReadOnly = true;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(146, 69);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 11;
            this.lblCargo.Text = "Cargo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(146, 47);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo";
            // 
            // pbxUser
            // 
            this.pbxUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxUser.Location = new System.Drawing.Point(12, 12);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(128, 125);
            this.pbxUser.TabIndex = 9;
            this.pbxUser.TabStop = false;
            // 
            // AsistenciaJornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.tblRegistro);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.pbxUser);
            this.Name = "AsistenciaJornada";
            this.Text = "AsistenciaJornada";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.DataGridView tblRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtComentarios;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.PictureBox pbxUser;
    }
}