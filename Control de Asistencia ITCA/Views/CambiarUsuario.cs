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
    public partial class frmCambiarUsuario : Form
    {
        public frmCambiarUsuario()
        {
            InitializeComponent();
        }

        AsistenciaJornada parentJornada = null;
        AsistenciaDocente parentDocente = null;
        public frmCambiarUsuario(AsistenciaJornada obj)
        {
            InitializeComponent();
            parentJornada = obj;
        }
        
        public frmCambiarUsuario(AsistenciaDocente obj)
        {
            InitializeComponent();
            parentDocente = obj;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ServicioAsistencia.ServicioAsistenciaClient servicio = new ServicioAsistencia.ServicioAsistenciaClient();

            if (Usuario.Sesion.clave == txtClave.Text)
            {
                if(parentDocente != null)
                {
                    servicio.updateEmpleado(Usuario.Sesion.idEmpleado, Usuario.Sesion.cedula, Usuario.Sesion.nombres, Usuario.Sesion.apellidos,
                   txtUsuario.Text, Usuario.Sesion.funcion, Usuario.Sesion.clave);
                    parentDocente.iniciarDatos();
                    parentDocente.cmbUserName.Items.RemoveAt(parentDocente.cmbUserName.Items.Count - 1);
                    this.Hide();
                }
                else
                {
                    servicio.updateEmpleado(Usuario.Sesion.idEmpleado, Usuario.Sesion.cedula, Usuario.Sesion.nombres, Usuario.Sesion.apellidos,
                   txtUsuario.Text, Usuario.Sesion.funcion, Usuario.Sesion.clave);
                    parentJornada.iniciarDatos();
                    parentJornada.cmbUserName.Items.RemoveAt(parentJornada.cmbUserName.Items.Count - 1);
                    this.Hide();
                }
               
            }
            else
            {
                MessageBox.Show("La contraseña es incorrecta, porfavor intente nuevamente.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
