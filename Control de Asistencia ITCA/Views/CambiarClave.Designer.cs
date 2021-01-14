
namespace Control_de_Asistencia_ITCA.Views
{
    partial class frmCambiarClave
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
            this.txtNuevaClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtClaveActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.Location = new System.Drawing.Point(26, 121);
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.PasswordChar = '●';
            this.txtNuevaClave.Size = new System.Drawing.Size(208, 20);
            this.txtNuevaClave.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nueva contraseña:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(98, 206);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.Location = new System.Drawing.Point(27, 77);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PasswordChar = '●';
            this.txtClaveActual.Size = new System.Drawing.Size(207, 20);
            this.txtClaveActual.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña actual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "EDITAR CONTRASEÑA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ingrese nuevamente su nueva contraeña:";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(27, 165);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '●';
            this.txtConfirmarClave.Size = new System.Drawing.Size(207, 20);
            this.txtConfirmarClave.TabIndex = 13;
            // 
            // frmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 256);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNuevaClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambiarClave";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cambiar Clave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNuevaClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmarClave;
    }
}