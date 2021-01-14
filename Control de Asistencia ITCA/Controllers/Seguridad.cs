using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Asistencia_ITCA.Controllers
{
    public static class Seguridad
    {
        static ServicioAsistencia.ServicioAsistenciaClient servicio = new ServicioAsistencia.ServicioAsistenciaClient();

        //ENCRIPTAR UNA CADENA
        public static string Encriptar(this string cadenaEncriptar)
        {
            string result = string.Empty;
            byte[] encriptado = System.Text.Encoding.Unicode.GetBytes(cadenaEncriptar);
            result = Convert.ToBase64String(encriptado);
            return result;

        }

        //DESENCRIPTAR UNA CADENA
        public static string Desencriptar(this string cadenaDesencriptar)
        {
            string result = string.Empty;
            byte[] desencriptado = Convert.FromBase64String(cadenaDesencriptar);
            result = System.Text.Encoding.Unicode.GetString(desencriptado);
            return result;
        }
    }
}
