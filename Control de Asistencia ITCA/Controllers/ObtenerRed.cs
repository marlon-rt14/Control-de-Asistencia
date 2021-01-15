using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_Asistencia_ITCA.Controllers
{
    class ObtenerRed
    {
        public static string obtenerFQDN()
        {
            try
            {
                //Obtener nombre de red sin dominio
                String nombreDeRedSinDominio = Dns.GetHostName();
                //Obtener nombre de red con dominio (Fully qualified hostname)
                String nombreDeRed = Dns.GetHostEntry(nombreDeRedSinDominio).HostName;
                return nombreDeRed;
            }
            catch (SocketException e)
            {
                Console.WriteLine("Error al obtener nombre de red del equipo");
                Console.WriteLine("  Origen: " + e.Source);
                Console.WriteLine("   Error: " + e.Message);
                return "";
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al obtener nombre de red del equipo");
                Console.WriteLine("  Origen: " + e.Source);
                Console.WriteLine("   Error: " + e.Message);
                return "";
            }
        }
    }
}
