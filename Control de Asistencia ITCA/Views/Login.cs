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
            if(ObtenerRed.obtenerFQDN() == Valores.valores.red)
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
                    //DECLARAR UNA VARIABLE COMO BANDERA DE LA CLAVE
                    string auxClave = "";
                    //RECORRER TODA LA LISTA DE EMPLEADOS PARA VALIDAR USUARIO Y CONTRASEÑA
                    foreach (ServicioAsistencia.empleado item in listaEmpleados)
                    {
                        //VALIDAR USUARIO Y CONTRASEÑA
                        if (item.usuario == txtUsuario.Text)
                        {
                            //VALIDAR SI EL USUARIO INGRESA POR PRIMERA VEZ PARA ENCRIPTAR SU CLAVE ACTUAL
                            if (item.clave == txtClave.Text)
                            {
                                auxClave = txtClave.Text;
                                encontrado = true;
                                //RECUPERAR EL ID DEL EMPLEADO ACTUAL
                                idEmpleadoActual = item.idEmpleado;
                                break;
                            }
                            //CASO CONTRARIO SI SU CLAVE YA ESTA ENCRIPTADA, DESENCRIPTAR Y COMPARAR CON LA QUE INGRESÓ
                            else
                            {
                                if (txtClave.Text == Seguridad.Desencriptar(item.clave))
                                {
                                    encontrado = true;
                                    //RECUPERAR EL ID DEL EMPLEADO ACTUAL
                                    idEmpleadoActual = item.idEmpleado;
                                    break;
                                }
                            }

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

                            //GUARDAR PRIMERA VEZ
                            if (Usuario.Sesion.clave == auxClave)
                            {
                                GetServicio.updateEmpleado(Usuario.Sesion.idEmpleado, Usuario.Sesion.cedula, Usuario.Sesion.nombres,
                                Usuario.Sesion.apellidos, Usuario.Sesion.usuario, Usuario.Sesion.funcion,
                                Seguridad.Encriptar(auxClave));
                            }

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
            else
            {
                MessageBox.Show("Usted no se encuentra en la institución, por favor aceérquese para registrar su asistencia.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
