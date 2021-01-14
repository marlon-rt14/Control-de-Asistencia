using Control_de_Asistencia_ITCA.Controllers;
using Control_de_Asistencia_ITCA.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Asistencia_ITCA.Views
{
    public partial class frmCambiarClave : Form
    {
        public frmCambiarClave()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ServicioAsistencia.ServicioAsistenciaClient servicio = new ServicioAsistencia.ServicioAsistenciaClient();

            if (txtClaveActual.Text == Seguridad.Desencriptar(Usuario.Sesion.clave))
            {
                if (txtNuevaClave.Text == txtConfirmarClave.Text)
                {
                    servicio.updateEmpleado(Usuario.Sesion.idEmpleado, Usuario.Sesion.cedula, Usuario.Sesion.nombres,
               Usuario.Sesion.apellidos, Usuario.Sesion.usuario, Usuario.Sesion.funcion, 
               Seguridad.Encriptar(txtConfirmarClave.Text));
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden, intente nuevamente.", "Advertencia",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("La contraseña actual no coincide con nuestros registros, intente nuevamente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
