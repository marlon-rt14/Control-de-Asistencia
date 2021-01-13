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

        public string Recursos { get; private set; }

        public void iniciarDatos()
        {
            //INICIAR EL HORARIO DE ASISTENCIA DE DOCENTE ACTUAL
            iniciar.iniciarHorarioAsistencia(tblHorarioAsistencia);

            //SELECCIONAR LA FILA PROXIMA A LA ASISTENCIA
            auxSeleccionar();

            //ESTABLECER EN EL COMOBOBOX EL NOMBRE DEL USUARIO ACTUALMENTE INGRESADO
            cmbUserName.Items.Add(getNombre(servicio.getListNombresCompletos()));
            cmbUserName.SelectedIndex = 2;

            lblTipo.Text = Tipo.SesionTipo.descripcionTipo;
            lblCargo.Text = Usuario.Sesion.funcion;
        }
        
        public void auxSeleccionar()
        {
            var timer = new System.Timers.Timer(TimeSpan.FromSeconds(0.5).TotalMilliseconds);
            timer.Elapsed += (sender, e) =>
            {
                if (DateTimeInternet())
                {
                    DateTimeOffset horaInternet = InternetTime.GetCurrentTime().Value.ToLocalTime();
                    seleccionarFila(horaInternet);
                }
                else
                {
                    DateTime horaLocal = DateTime.Today;
                    seleccionarFila(horaLocal);
                }
            };
            timer.Start();
        }

        public void seleccionarFila(DateTimeOffset fecha)
        {
            foreach (DataGridViewRow row in tblHorarioAsistencia.Rows)
            {
                DateTime auxFecha = DateTime.Parse(row.Cells["txtFecha"].Value.ToString());
                DateTime actualFecha = DateTime.Parse(fecha.ToString("dd/MM/yyyy"));
                if (actualFecha.Date < auxFecha.Date)
                {
                    DateTime horaInicio = DateTime.Parse(row.Cells["txtIniciar"].Value.ToString());
                    DateTime horaActual = DateTime.Parse(fecha.ToString("HH:mm"));
                    if (horaActual.Date < horaInicio.Date)
                    {
                        row.Selected = true;
                        row.DefaultCellStyle.BackColor = Color.FromArgb(50, 205, 50);
                    }
                }
            }
        }

        private void btnAsistenciaDocente_Click(object sender, EventArgs e)
        {
            RegistroAsistenciaDocente registro = new RegistroAsistenciaDocente();
            registro.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (InternetTime.GetCurrentTime().Value.ToLocalTime() != null)
            {
                DateTime horaInternet = DateTime.Parse(InternetTime.GetCurrentTime().Value.ToLocalTime().ToString("dd/MM/yyyy"));

            }
            else
            {
                DateTime horaLocal = DateTime.Parse(DateTime.Today.ToString("dd/MM/yyyy"));

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

        private void tblHorarioAsistencia_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {
            //auxSeleccionar();
        }
    }
}

