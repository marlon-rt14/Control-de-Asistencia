
namespace Control_de_Asistencia_ITCA
{
    partial class AsistenciaDocente
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
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAsistenciaDocente = new System.Windows.Forms.Button();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.tblHorarioAsistencia = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIniciar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtConcluir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHorarioAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxUser
            // 
            this.pbxUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxUser.Location = new System.Drawing.Point(12, 12);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(128, 125);
            this.pbxUser.TabIndex = 0;
            this.pbxUser.TabStop = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(146, 47);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(146, 69);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbxLogo.BackgroundImage = global::Control_de_Asistencia_ITCA.Properties.Resources.itca;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(711, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(96, 96);
            this.pbxLogo.TabIndex = 5;
            this.pbxLogo.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(146, 114);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar Asistencia";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAsistenciaDocente
            // 
            this.btnAsistenciaDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsistenciaDocente.Location = new System.Drawing.Point(663, 114);
            this.btnAsistenciaDocente.Name = "btnAsistenciaDocente";
            this.btnAsistenciaDocente.Size = new System.Drawing.Size(144, 23);
            this.btnAsistenciaDocente.TabIndex = 7;
            this.btnAsistenciaDocente.Text = "Registro de Asistencia";
            this.btnAsistenciaDocente.UseVisualStyleBackColor = true;
            this.btnAsistenciaDocente.Click += new System.EventHandler(this.btnAsistenciaDocente_Click);
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
            this.cmbUserName.TabIndex = 8;
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
            this.txtAula,
            this.txtMateria,
            this.txtIniciar,
            this.txtConcluir,
            this.txtFecha});
            this.tblHorarioAsistencia.Location = new System.Drawing.Point(12, 143);
            this.tblHorarioAsistencia.MultiSelect = false;
            this.tblHorarioAsistencia.Name = "tblHorarioAsistencia";
            this.tblHorarioAsistencia.ReadOnly = true;
            this.tblHorarioAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblHorarioAsistencia.Size = new System.Drawing.Size(797, 312);
            this.tblHorarioAsistencia.TabIndex = 9;
            this.tblHorarioAsistencia.ColumnSortModeChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.tblHorarioAsistencia_ColumnSortModeChanged);
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
            // txtAula
            // 
            this.txtAula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtAula.FillWeight = 106.7893F;
            this.txtAula.HeaderText = "Aula";
            this.txtAula.Name = "txtAula";
            this.txtAula.ReadOnly = true;
            // 
            // txtMateria
            // 
            this.txtMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtMateria.FillWeight = 106.7893F;
            this.txtMateria.HeaderText = "Materia";
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.ReadOnly = true;
            // 
            // txtIniciar
            // 
            this.txtIniciar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtIniciar.FillWeight = 106.7893F;
            this.txtIniciar.HeaderText = "Iniciar";
            this.txtIniciar.Name = "txtIniciar";
            this.txtIniciar.ReadOnly = true;
            // 
            // txtConcluir
            // 
            this.txtConcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtConcluir.FillWeight = 106.7893F;
            this.txtConcluir.HeaderText = "Concluir";
            this.txtConcluir.Name = "txtConcluir";
            this.txtConcluir.ReadOnly = true;
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtFecha.FillWeight = 106.7893F;
            this.txtFecha.HeaderText = "Fecha";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            // 
            // AsistenciaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 467);
            this.Controls.Add(this.tblHorarioAsistencia);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.btnAsistenciaDocente);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.pbxUser);
            this.Name = "AsistenciaDocente";
            this.Text = "Control de Asistencia ITCA";
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHorarioAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAsistenciaDocente;
        private System.Windows.Forms.ComboBox cmbUserName;
        public System.Windows.Forms.DataGridView tblHorarioAsistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIniciar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtConcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFecha;
    }
}

