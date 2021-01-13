using Control_de_Asistencia_ITCA.Modelo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Asistencia_ITCA.Controllers
{
    public class IniciarDatos
    {

        //CONECTARSE AL SERVIDODR
        private static ServicioAsistencia.ServicioAsistenciaClient clienteServicio = new ServicioAsistencia.ServicioAsistenciaClient();

        public DateTime fechaMenor = DateTime.Parse("01/01/2050");
        public void iniciarHorarioAsistencia(DataGridView dtm)
        {
            //RECUPERAR TODAS LAS ELEMENTOS DE LA VISTA DOCENTES
            IList<ServicioAsistencia.vistaDocente> listViewDocentes = clienteServicio.getListVistaDocente();
            //ESTABLECER EL VALOR DE LAS FILAS EN 0
            dtm.RowCount = 0;
            //RECORRER CADA ITEM TIPO VISTA DOCENTE DE LA LISTA VISTA DOCENTES
            listViewDocentes.ToList().ForEach(item =>
            {
                //VALIDAR QUE SE MUESTREN LOS DATOS SOLO DEL USUARIO QUE INICIO SESION 
                if (item.cedula == Usuario.Sesion.cedula)
                {
                    //AGREGAR UNA NUEVA FILA
                    dtm.Rows.Add(new object[] { item.idEmpleado, item.descripcionTipo,
                    item.cedula, item.nombreEmpleado, item.descripcionAula, item.descripcionMateria,
                    item.horaInicio.ToString("HH:mm"), item.horaFin.ToString("HH:mm"),item.fecha.ToString("dd/MM/yyyy")});

                    DateTime fechaIterator = DateTime.Parse(item.fecha.ToString("dd/MM/yyyy"));
                    //VALIDAR FECHA
                    if (fechaIterator.Date < fechaMenor.Date)
                    {
                        fechaMenor = fechaIterator.Date;
                    }
                }
            });
        }

        public void iniciarRegistroAsistencia(DataGridView dtm)
        {
            dtm.RowCount = 0;
            Func<IList<ServicioAsistencia.vistaNombreCompleto>, string> getNombre = lista =>
            {
                foreach (ServicioAsistencia.vistaNombreCompleto item in lista)
                {
                    if (item.idEmpleado == Usuario.Sesion.idEmpleado)
                    {
                        return item.nombreEmpleado;
                    }
                }
                return "";
            };
            clienteServicio.getListAsistencia().ToList().ForEach(item =>
            {
                if (item.idEmpleado.cedula == Usuario.Sesion.cedula)
                {
                    dtm.Rows.Add(new object[] { item.idAsistencia, item.idTipoEmpleado.idTipo.descripcionTipo, item.idEmpleado.cedula,
                        getNombre(clienteServicio.getListNombresCompletos()), item.mensajeAsistencia,
                    item.idFechaHabil.fecha.ToString("dd/MM/yyyy"), item.idEstado.descripcionEstado, item.comentarios, item.observaciones});
                }
            });
        }

    }
}
