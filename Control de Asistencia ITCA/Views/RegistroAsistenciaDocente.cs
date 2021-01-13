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
    public partial class RegistroAsistenciaDocente : Form
    {
        public RegistroAsistenciaDocente()
        {
            InitializeComponent();
            iniciarDatos();
        }

        //ServicioAsistencia.ServicioAsistenciaClient servicio = new ServicioAsistencia.ServicioAsistenciaClient();

        public void iniciarDatos()
        {
            IniciarDatos iniciar = new IniciarDatos();
            iniciar.iniciarRegistroAsistencia(tblAsistencia);

            lblDescripcionAsistencia.Text = Valores.valores.infoRegistroAsistecia;
        }
    }
}
