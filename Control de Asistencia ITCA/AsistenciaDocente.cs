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
    public partial class AsistenciaDocente : Form
    {
        public AsistenciaDocente()
        {
            InitializeComponent();
            //AJUSTAR LOS MENU DESCPLEGABLE DEL COMBO A LOS ITEMS 
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
        IniciarDatos iniciar = new IniciarDatos();

        //RECUPERAR EL NOMBRE COMPLETO DEL USURIO QUE INGRESO
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

        public void validaciones()
        {
            Validar validar = new Validar();
            validar.validarAsistencia(btnRegistrar, tblHorarioAsistencia);
        }

        public void iniciarDatos()
        {
            //INICIAR EL HORARIO DE ASISTENCIA DE DOCENTE ACTUAL
            iniciar.HorarioAsistencia(tblHorarioAsistencia);            

            //ESTABLECER EN EL COMOBOBOX EL NOMBRE DEL USUARIO ACTUALMENTE INGRESADO
            cmbUserName.Items.Add(getNombre(servicio.getListNombresCompletos()));
            cmbUserName.SelectedIndex = 2;

            lblTipo.Text = Tipo.SesionTipo.descripcionTipo;
            lblCargo.Text = Usuario.Sesion.funcion;
        }

       

        public void auxSeleccionar()
        {
            //ESTABLECER UN TEMPORIZADOR CADA CIERTO TIEMPO
            var timer = new System.Timers.Timer(TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            //LA ACCION QUE VA A HACER AL ALCANZAR EL TIEMPO LIMITE
            timer.Elapsed += (sender, e) =>
            {
                if (DateTimeInternet())
                {
                    DateTimeOffset horaInternet = InternetTime.GetCurrentTime().Value.ToLocalTime();
                    seleccionarFila(horaInternet);
                }
                else
                {
                    DateTimeOffset horaLocal = DateTime.Today;
                    seleccionarFila(horaLocal);
                }
            };
            //INICIAR EL TEMPORIZADOR
            timer.Start();
        }

        public void seleccionarFila(DateTimeOffset fecha)
        {
            string horaMenor = tblHorarioAsistencia.Rows[0].Cells[6].Value.ToString();
            int id = 0;
            tblHorarioAsistencia.ClearSelection();
            foreach (DataGridViewRow row in tblHorarioAsistencia.Rows)
            {
               if( DateTime.Parse(row.Cells["txtIniciar"].Value.ToString()).Date < DateTime.Parse(horaMenor).Date)
                {
                    horaMenor = row.Cells["txtIniciar"].Value.ToString();
                    id = id++;
                }
            }

            if (btnRegistrar.Enabled)
            {
                DateTime horaInicio = DateTime.Parse(horaMenor);
                DateTime horaActual = DateTime.Parse(fecha.ToString("HH:mm"));
                if (horaActual.Date < horaInicio.Date)
                {
                    tblHorarioAsistencia.Rows[id].Selected = true;
                    //row.DefaultCellStyle.BackColor = Color.FromArgb(50, 205, 50);
                }
            }
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
            RegistroAsistenciaDocente registro = new RegistroAsistenciaDocente();
            registro.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            List<String> fechas = new List<string>();
            foreach (DataGridViewRow row in tblHorarioAsistencia.Rows)
            {
                fechas.Add(row.Cells["txtFecha"].Value.ToString());
            }
            Func<List<string>, ServicioAsistencia.estado> getEstado = lista =>
            {
                DateTime actual = DateTime.Parse(InternetTime.GetCurrentTime().Value.ToLocalTime().ToString("dd/MM/yyyy"));
                foreach (string item in lista)
                {
                    DateTime referencia = DateTime.Parse(item);
                    if (actual.Date < referencia.Date)
                    {
                        return servicio.getEstado(1);
                    }
                }
                return null;
            };
            servicio.saveAsistencia(Tipo.SesionTipo, Usuario.Sesion, Valores.valores.msjAsistenciaPresente,
                DateTime.Parse(DateTime.Today.ToString("dd/MM/yyyy")).Date, 
                getEstado(fechas), "Sin comentaros", "S/A");

            

            if (InternetTime.GetCurrentTime().Value.ToLocalTime() != null)
            {
                DateTime horaInternet = DateTime.Parse(InternetTime.GetCurrentTime().Value.ToLocalTime().ToString("dd/MM/yyyy"));

            }
            else
            {
                DateTime horaLocal = DateTime.Parse(DateTime.Today.ToString("dd/MM/yyyy"));

            }
        }

        private void tblHorarioAsistencia_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {
            //auxSeleccionar();
        }
    }
}

