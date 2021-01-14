
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
            this.tblHorarioAsistencia = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.btnAsistenciaDocente = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblHorarioAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tblHorarioAsistencia
            // 
            this.tblHorarioAsistencia.AllowUserToAddRows = false;
            this.tblHorarioAsistencia.AllowUserToDeleteRows = false;
            this.tblHorarioAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblHorarioAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tblHorarioAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblHorarioAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtTipo,
            this.txtCedula,
            this.txtNombre,
            this.txtFecha,
            this.txtEpp,
            this.txtSpp,
            this.txtEsp,
            this.txtSsp});
            this.tblHorarioAsistencia.Location = new System.Drawing.Point(12, 135);
            this.tblHorarioAsistencia.MultiSelect = false;
            this.tblHorarioAsistencia.Name = "tblHorarioAsistencia";
            this.tblHorarioAsistencia.ReadOnly = true;
            this.tblHorarioAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblHorarioAsistencia.Size = new System.Drawing.Size(879, 327);
            this.tblHorarioAsistencia.TabIndex = 17;
            // 
            // txtID
            // 
            this.txtID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtID.FillWeight = 45.68528F;
            this.txtID.HeaderText = "ID";
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtTipo.FillWeight = 106.7893F;
            this.txtTipo.HeaderText = "Tipo";
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            // 
            // txtCedula
            // 
            this.txtCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtCedula.FillWeight = 106.7893F;
            this.txtCedula.HeaderText = "Cédula";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNombre.FillWeight = 106.7893F;
            this.txtNombre.HeaderText = "Nombre";
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtFecha.FillWeight = 106.7893F;
            this.txtFecha.HeaderText = "Fecha";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            // 
            // txtEpp
            // 
            this.txtEpp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtEpp.FillWeight = 106.7893F;
            this.txtEpp.HeaderText = "Inicio - priemer periodo";
            this.txtEpp.Name = "txtEpp";
            this.txtEpp.ReadOnly = true;
            // 
            // txtSpp
            // 
            this.txtSpp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtSpp.FillWeight = 106.7893F;
            this.txtSpp.HeaderText = "Fin - primer periodo";
            this.txtSpp.Name = "txtSpp";
            this.txtSpp.ReadOnly = true;
            // 
            // txtEsp
            // 
            this.txtEsp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtEsp.FillWeight = 106.7893F;
            this.txtEsp.HeaderText = "Inicio - segundo periodo";
            this.txtEsp.Name = "txtEsp";
            this.txtEsp.ReadOnly = true;
            // 
            // txtSsp
            // 
            this.txtSsp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtSsp.FillWeight = 106.7893F;
            this.txtSsp.HeaderText = "Fin - segundo periodo";
            this.txtSsp.Name = "txtSsp";
            this.txtSsp.ReadOnly = true;
            // 
            // cmbUserName
            // 
            this.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Items.AddRange(new object[] {
            "Cambiar nombre de usuario",
            "Cambiar contraseña"});
            this.cmbUserName.Location = new System.Drawing.Point(157, 4);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(121, 21);
            this.cmbUserName.TabIndex = 16;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // btnAsistenciaDocente
            // 
            this.btnAsistenciaDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsistenciaDocente.Location = new System.Drawing.Point(747, 106);
            this.btnAsistenciaDocente.Name = "btnAsistenciaDocente";
            this.btnAsistenciaDocente.Size = new System.Drawing.Size(144, 23);
            this.btnAsistenciaDocente.TabIndex = 15;
            this.btnAsistenciaDocente.Text = "Registro de Asistencia";
            this.btnAsistenciaDocente.UseVisualStyleBackColor = true;
            this.btnAsistenciaDocente.Click += new System.EventHandler(this.btnAsistenciaDocente_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(157, 106);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 23);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar Asistencia";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbxLogo.BackgroundImage = global::Control_de_Asistencia_ITCA.Properties.Resources.itca;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(795, 4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(96, 96);
            this.pbxLogo.TabIndex = 13;
            this.pbxLogo.TabStop = false;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(154, 61);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 12;
            this.lblCargo.Text = "Cargo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(154, 39);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo";
            // 
            // pbxUser
            // 
            this.pbxUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxUser.Location = new System.Drawing.Point(12, 4);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(128, 125);
            this.pbxUser.TabIndex = 10;
            this.pbxUser.TabStop = false;
            // 
            // AsistenciaJornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 474);
            this.Controls.Add(this.tblHorarioAsistencia);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.btnAsistenciaDocente);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.pbxUser);
            this.Name = "AsistenciaJornada";
            this.Text = "AsistenciaJornada";
            ((System.ComponentModel.ISupportInitialize)(this.tblHorarioAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView tblHorarioAsistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEpp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSpp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSsp;
        private System.Windows.Forms.Button btnAsistenciaDocente;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.PictureBox pbxUser;
        public System.Windows.Forms.ComboBox cmbUserName;
    }
}