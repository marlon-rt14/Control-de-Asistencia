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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //HACER UNA REFERENCIA DE CONEXION CON EL SERVIDOR 
        ServicioAsistencia.ServicioAsistenciaClient GetServicio = new ServicioAsistencia.ServicioAsistenciaClient();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //VALIDAR ALGUN POSIBLE ERROR CON LA CONEXION AL SERVIDOR
            try
            {
                //TENER UNA LISTA DE TODOS LOS EMPLEADOS
                IList<ServicioAsistencia.empleado> listaEmpleados = GetServicio.getListEmpleados();
                //DECLARAR UNA VARIABLE PARA EL ID DEL EMPLEADO ACTUAL
                int idEmpleadoActual = new int();
                //USUARIO ENCONTRAD
                bool encontrado = false;
                //RECORRER TODA LA LISTA DE EMPLEADOS PARA VALIDAR USUARIO Y CONTRASEÑA
                foreach (ServicioAsistencia.empleado item in listaEmpleados)
                {
                    //VALIDAR USUARIO Y CONTRASEÑA
                    if (item.usuario == txtUsuario.Text && item.clave == txtClave.Text)
                    {
                        encontrado = true;
                        //RECUPERAR EL ID DEL EMPLEADO ACTUAL
                        idEmpleadoActual = item.idEmpleado;
                        break;
                    }
                }

                if (encontrado)
                {
                    //IDENTIFCAR QUE TIPO DE EMPLEADO ES EL QUE INGRESO
                    ServicioAsistencia.tipo tipo = validarTipoEmpleado(idEmpleadoActual);
                    //GUARDAR EL TIPO EN UNA NUEVA CLASE
                    Tipo.SesionTipo = tipo;
                    //ABRIR EL RESPECTIVO FORMULARIO SEGUN EL TIPO
                    if (tipo != null && tipo.descripcionTipo == "Docente")
                    {
                        ServicioAsistencia.empleado empleadoActual = GetServicio.getEmpleado(idEmpleadoActual);
                        Usuario.Sesion = empleadoActual;

                        //ABRIR FORMULARIOS PARA DOCENTES
                        AsistenciaDocente childDocente = new AsistenciaDocente();
                        this.Hide();
                        childDocente.Show();
                        //this.Close();
                    }
                    else if (tipo != null && (tipo.descripcionTipo == "Administrativo" || tipo.descripcionTipo == "Limpieza"))
                    {
                        ServicioAsistencia.empleado empleadoActual = GetServicio.getEmpleado(idEmpleadoActual);
                        Usuario.Sesion = empleadoActual;
                        //ABRIR FORMULARIOS PARA ADMINISTRATIVOS
                        AsistenciaJornada childJornada = new AsistenciaJornada();
                        this.Hide();
                        childJornada.Show();
                        //this.Dispose();
                    }
                    //this.Close();
                }
                else
                {
                    MessageBox.Show(Valores.valores.msjCredencialesIncorrectos, Valores.valores.titleErrorCredenciales,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Valores.valores.msjErrorServidor, Valores.valores.titleErrorServidor, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public ServicioAsistencia.tipo validarTipoEmpleado(int empleadoActual)
        {
            IList<ServicioAsistencia.tipoEmpleado> listaTiposEmpleados = GetServicio.getListTiposEmpleados();
            foreach (ServicioAsistencia.tipoEmpleado item in listaTiposEmpleados)
            {
                if (item.idEmpleado.idEmpleado == empleadoActual)
                {
                    return item.idTipo;
                }
            }
            return null;
        }
    }
}
