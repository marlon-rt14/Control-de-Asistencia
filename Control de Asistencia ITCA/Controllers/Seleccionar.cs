using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Asistencia_ITCA.Controllers
{
    public class Seleccionar
    {

        public void seleccionarFila(DateTimeOffset horaInternet, DataGridView dtm, string inicio, string fecha, 
 int columna)
        {
            string horaMenor = dtm.Rows[0].Cells[columna].Value.ToString();
            int id = 0;
            foreach (DataGridViewRow row in dtm.Rows)
            {
                string auxInternet = horaInternet.ToString("dd/MM/yyyy");
                string auxRegistro = row.Cells[fecha].Value.ToString();
                if (DateTime.Parse(row.Cells[inicio].Value.ToString()).Date < DateTime.Parse(horaMenor).Date
                    && DateTime.Parse(auxRegistro).Date == DateTime.Parse(auxInternet).Date)
                {
                    horaMenor = row.Cells[inicio].Value.ToString();
                    id = id++;
                }
            }

            dtm.ClearSelection();
            DateTime horaInicio = DateTime.Parse(horaMenor);
            DateTime horaActual = DateTime.Parse(horaInternet.ToString("HH:mm"));
            if (horaActual.Date < horaInicio.Date)
            {
                dtm.Rows[id].Selected = true;
                //row.DefaultCellStyle.BackColor = Color.FromArgb(50, 205, 50);
            }
        }

    }
}
