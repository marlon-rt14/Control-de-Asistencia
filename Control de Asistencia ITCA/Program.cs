using Control_de_Asistencia_ITCA.Controllers;
using Control_de_Asistencia_ITCA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Asistencia_ITCA
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Application.Run(new AsistenciaDocente());
            //Application.Run(new RegistroAsistenciaDocente());
            //Application.Run(new frmCambiarClave());
            //Application.Run(new prueba());
        }
    }
}
