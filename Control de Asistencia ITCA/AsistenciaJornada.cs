using Control_de_Asistencia_ITCA.Controllers;
using Control_de_Asistencia_ITCA.Modelo;
using Control_de_Asistencia_ITCA.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Asistencia_ITCA
{
    public partial class AsistenciaJornada : Form
    {
        public AsistenciaJornada()
        {
            InitializeComponent();
            cmbUserName.DropDownWidth = DropDownWidth(cmbUserName);
            iniciarDatos();
            validaciones();
            auxSeleccionar();
        }

        int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0;
            int temp = 0;
            Label label1 = new Label();

            foreach (var obj in myCombo.Items)
            {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            return maxWidth;
        }

        //HACER REFERENCIA A NUESTRO SERVIDOR
        ServicioAsistencia.ServicioAsistenciaClient servicio = new ServicioAsistencia.ServicioAsistenciaClient();

        //HACER REFERENCIA A LA CLASE INICIAR DATOS
        IniciarDatos inicar = new IniciarDatos();

        //RECUPERAR EL NOMBRE COMPLETO DEL USUARIO QUE INICIO SESION
        Func<IList<ServicioAsistencia.vistaNombreCompleto>, string> getNombre = lista =>
        {
            foreach (ServicioAsistencia.vistaNombreCompleto item in lista)
            {
                if (item.idEmpleado == Usuario.Sesion.idEmpleado)
                {
                    return item.nombreEmpleado;
                }
            }
            return "";
        };

        public void iniciarDatos()
        {
            //INICIAR EL HORARIO DE ASISTENCIA DEL EMPLEADO ADMINISTRATIVO
            inicar.JornadaAsistencia(tblHorarioAsistencia);

            //ESTABLECER E EL COMBOBOX EL NOMBRE DEL USUARIO ACTUALMENTE INGRESADO
            cmbUserName.Items.Add(getNombre(servicio.getListNombresCompletos()));
            cmbUserName.SelectedIndex = 2;

            lblTipo.Text = Tipo.SesionTipo.descripcionTipo;
            lblCargo.Text = Usuario.Sesion.funcion;
        }

        public void validaciones()
        {
            Validar validar = new Validar();
            validar.validarAsistencia(btnRegistrar, tblHorarioAsistencia);
        }

        public void auxSeleccionar()
        {
            //ESTABLECER UN TEMPORIZADOR CADA CIERTO TIEMPO
            var timer = new System.Timers.Timer(TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            //HACER REFERENCIA A LA CLASE SELECCIONAR PARA SELECCIONAR LA FILA
            Seleccionar seleccionar = new Seleccionar();
            //LA ACCION QUE VA  A HACER AL ALCANZAR EL TIEMPO LIMITE 
            timer.Elapsed += (sender, e) =>
            {
                //VALIDAR QUE LA FECHA DEL REGISTRO SEA IGUAL A LA DE HOY
                validaciones();
                if (btnRegistrar.Enabled) // SI ES ES IGUAL EL BOTON DE REGISTRAR ASISTENCIA ESTARA ACTIVADO
                {
                    //OBTENER LA HORA DE INTERNET
                    if (DateTimeInternet())
                    {
                        DateTimeOffset horaInternet = InternetTime.GetCurrentTime().Value.ToLocalTime();
                        seleccionar.seleccionarFila(horaInternet, tblHorarioAsistencia, "txtInicio", "txtFecha", 4);

                    }
                    else
                    {
                        DateTimeOffset horaLocal = DateTime.Today;
                        seleccionar.seleccionarFila(horaLocal, tblHorarioAsistencia, "txtInicio", "txtFecha", 4);
                    }
                }
            };
            //INICIAR EL TEMPORIZADOR
            timer.Start();
        }

        public bool DateTimeInternet()
        {
            if (InternetTime.GetCurrentTime().Value.ToLocalTime() != null)
            {
                return true;
            }
            return false;
        }

        private void btnAsistenciaDocente_Click(object sender, EventArgs e)
        {
            HistorialAsistencia registro = new HistorialAsistencia();
            registro.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            List<String> horasNormales = new List<string>();
            List<String> horasMaximas = new List<string>();
            string mensaje = "";
            //LLENAR UNA LISTA DE FECHAS
            foreach (DataGridViewRow row in tblHorarioAsistencia.Rows)
            {
                //fechas.Add(row.Cells["txtFecha"].Value.ToString());
                DateTime horaRegistro = DateTime.Parse(row.Cells["txtInicio"].Value.ToString());
                horaRegistro.AddMinutes(15);
                horasMaximas.Add(horaRegistro.ToString("HH:mm"));
                horasNormales.Add(row.Cells["txtInicio"].Value.ToString());
            }
            Func<List<string>, ServicioAsistencia.estado> getEstado = listaHoras =>
            {
                try
                {
                    DateTime actualInternet = DateTime.Parse(InternetTime.GetCurrentTime().Value.ToLocalTime().ToString("HH:mm"));
                    DateTime actualLocal = DateTime.Parse(DateTime.Today.ToString("HH:mm"));
                    for (int i = 0; i < listaHoras.Count; i++)
                    {
                        DateTime auxHora = DateTime.Parse(listaHoras[i]);
                        DateTime auxHoraMax = DateTime.Parse(horasMaximas[i]);
                        if ((actualInternet.Date >= auxHora.Date && actualInternet.Date <= auxHoraMax.Date) ||
                        (actualLocal.Date >= auxHora.Date && actualLocal.Date <= auxHoraMax.Date))
                        {
                            mensaje = Valores.valores.msjAsistenciaPresente;
                            return servicio.getEstado(1);
                        }
                        else if (actualInternet.Date > auxHoraMax.Date.AddHours(2) || actualLocal.Date > auxHoraMax.Date.AddHours(2))
                        {
                            mensaje = Valores.valores.msjAsistenciaAtraso;
                            return servicio.getEstado(2);
                        }
                        else
                        {
                            mensaje = Valores.valores.msjAsistenciaInjustificado;
                            return servicio.getEstado(3);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producio una excepción al obtener la fecha y hora.", "Exception",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return null;
            };
            DateTimeOffset fechaActual = InternetTime.GetCurrentTime().Value.ToLocalTime();
            if (DateTimeInternet())
            {
                servicio.saveAsistencia(Tipo.SesionTipo, Usuario.Sesion, mensaje,
                DateTime.Parse(fechaActual.ToString("dd/MM/yyyy")).Date,
                getEstado(horasNormales), "Sin comentaros", "S/A");
            }
            else
            {
                servicio.saveAsistencia(Tipo.SesionTipo, Usuario.Sesion, mensaje,
               DateTime.Parse(DateTime.Today.ToString("dd/MM/yyyy")).Date,
               getEstado(horasNormales), "Sin comentaros", "S/A");
            }
        }
    }
}
