using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class AlumnoCN
    {
        AlumnoCD ObjaLUM = new AlumnoCD();

        public List<AlumnoCE> ObtenerAlumnos()
        {
            return ObjaLUM.ObtenerAlumno();
        }

        public bool InsertarAlumno(AlumnoCE objAlumn)
        {
            return ObjaLUM.InsertarAlumno(objAlumn);
        }
        public AlumnoCE ObtenerAlumnoId(int id)
        {
            return ObjaLUM.ObtenerCAlumnoId(id);
        }
        public bool EliminarAlumno(int id)
        {
            return ObjaLUM.EliminarAlumno(id);
        }
        public bool ActualizarAlumno(AlumnoCE cli)
        {
            return ObjaLUM.ActualizarAlumno(cli);
        }

    }
}
