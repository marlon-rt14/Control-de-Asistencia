using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Asistencia_ITCA.Controllers
{
    class ObtenerRed
    {
        public static string obtenerFQDN()
        {
            try
            {
                var process = new Process
                {
                    StartInfo =
    {
    FileName = "netsh.exe",
    Arguments = "wlan show interfaces",
    UseShellExecute = false,
    RedirectStandardOutput = true,
    CreateNoWindow = true
    }
                };
                process.Start();

                var output = process.StandardOutput.ReadToEnd();
                //var line = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault(l => l.Contains("SSID") && !l.Contains("BSSID"));
                var line = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault(l => l.Contains("BSSID"));
                if (line == null)
                {
                    //return string.Empty;
                    return null;
                }
                //var ssid = line.Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries)[1].TrimStart();
                var mac = line.Substring(20).Trim();
                return mac;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
