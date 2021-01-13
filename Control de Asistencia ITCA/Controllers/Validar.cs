using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Asistencia_ITCA.Controllers
{
    public class Validar
    {

        public void validarAsistencia(Button btnAsistencia, DataGridView dtm)
        {
            List<String> fechas = new List<string>();
            foreach (DataGridViewRow row in dtm.Rows)
            {
                fechas.Add(row.Cells["txtFecha"].Value.ToString());
            }
            fechas.ForEach(item =>
            {
                if (DateTime.Parse(DateTime.Today.ToString("dd/MM/yyyy")).Date == DateTime.Parse(item).Date)
                {
                    btnAsistencia.Enabled = true ;
                }
                else
                {
                    btnAsistencia.Enabled = false;
                }
            });
        }
    }
}
