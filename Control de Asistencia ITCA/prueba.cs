using Control_de_Asistencia_ITCA.Controllers;
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
    public partial class prueba : Form
    {
        public prueba()
        {
            InitializeComponent();

        }

        private void prueba_Load(object sender, EventArgs e)
        {
            string red = ObtenerRed.obtenerFQDN();
            //if (red == "")
            //{
            //    MessageBox.Show("Error al obtener el nombre de red del equipo.");
            //}else
            //{
            //    MessageBox.Show("La red es: " + red);
            //}
            MessageBox.Show("LA RED ES: " + red);
        }
    }
}
