
namespace Control_de_Asistencia_ITCA.Views
{
    partial class RegistroAsistenciaDocente
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
            this.tblAsistencia = new System.Windows.Forms.DataGridView();
            this.lblDescripcionAsistencia = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComentarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAsistencia
            // 
            this.tblAsistencia.AllowUserToAddRows = false;
            this.tblAsistencia.AllowUserToDeleteRows = false;
            this.tblAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtTipo,
            this.txtCedula,
            this.txtNombre,
            this.txtDescripcion,
            this.txtFecha,
            this.txtEstado,
            this.txtComentarios,
            this.txtObservaciones});
            this.tblAsistencia.Location = new System.Drawing.Point(12, 28);
            this.tblAsistencia.Name = "tblAsistencia";
            this.tblAsistencia.ReadOnly = true;
            this.tblAsistencia.Size = new System.Drawing.Size(974, 488);
            this.tblAsistencia.TabIndex = 0;
            // 
            // lblDescripcionAsistencia
            // 
            this.lblDescripcionAsistencia.AutoSize = true;
            this.lblDescripcionAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionAsistencia.Location = new System.Drawing.Point(12, 9);
            this.lblDescripcionAsistencia.Name = "lblDescripcionAsistencia";
            this.lblDescripcionAsistencia.Size = new System.Drawing.Size(212, 16);
            this.lblDescripcionAsistencia.TabIndex = 1;
            this.lblDescripcionAsistencia.Text = "Registro de Asistencia del usuario";
            // 
            // txtID
            // 
            this.txtID.FillWeight = 10F;
            this.txtID.HeaderText = "ID";
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.txtID.Width = 40;
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtTipo.HeaderText = "Tipo";
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            // 
            // txtCedula
            // 
            this.txtCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtCedula.HeaderText = "Cédula";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNombre.HeaderText = "Nombre";
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtDescripcion.HeaderText = "Descripción";
            this.txtDescripcion.MinimumWidth = 350;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtFecha.HeaderText = "Fecha";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtEstado.HeaderText = "Estado";
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            // 
            // txtComentarios
            // 
            this.txtComentarios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtComentarios.HeaderText = "Comentarios";
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.ReadOnly = true;
            this.txtComentarios.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.HeaderText = "Observaciones";
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            // 
            // RegistroAsistenciaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 528);
            this.Controls.Add(this.lblDescripcionAsistencia);
            this.Controls.Add(this.tblAsistencia);
            this.MinimizeBox = false;
            this.Name = "RegistroAsistenciaDocente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Registro de Asistencia";
            ((System.ComponentModel.ISupportInitialize)(this.tblAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblAsistencia;
        private System.Windows.Forms.Label lblDescripcionAsistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtComentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtObservaciones;
    }
}