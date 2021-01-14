using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Asistencia_ITCA.Valores
{
    class valores
    {
        public static string infoRegistroAsistecia = "Registro de Asistencia del empleado ";
        public static string msjErrorServidor = "No se ha logrado establecer una conexión con el servidor.";
        public static string titleErrorServidor = "Error";
        public static string msjCredencialesIncorrectos = "El usuario o la contraseña no son correctos, verifiqe sus datos e intente de nuevo.";
        public static string titleErrorCredenciales = "Error";
        public static string msjAsistenciaPresente = "Su asistencia ha sido guardada como Presente a las " + DateTime.Today.ToString("HH:mm");
        public static string msjAsistenciaAtraso = "Su asistencia ha sido guardada como Atraso a las " + DateTime.Today.ToString("HH:mm");
        public static string msjAsistenciaInjustificado = "Su asistencia ha sido guardada como Injustificado a las " + DateTime.Today.ToString("HH:mm");
    }
}
