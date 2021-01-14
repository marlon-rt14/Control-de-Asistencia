using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Asistencia_ITCA.Controllers
{
    class Horas
    {

        public string[] getMenor(DataGridView dtm, string celda, int columna)
        {
            string horaMenor = dtm.Rows[0].Cells[columna].Value.ToString();
            int id = 0;
            foreach (DataGridViewRow row in dtm.Rows)
            {
                if (DateTime.Parse(row.Cells[celda].Value.ToString()).Date < DateTime.Parse(horaMenor).Date)
                {
                    horaMenor = row.Cells[celda].Value.ToString();
                    id = id++;
                }
            }
            return new string [] { horaMenor, id.ToString() };
        }

    }
}
