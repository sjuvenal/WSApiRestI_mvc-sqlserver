using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class CursoCN
    {
        CursoCD ObjaCur = new CursoCD();

        public List<CursoCE> ObtenerCursos()
        {
            return ObjaCur.ObtenerCurso();
        }

        public bool InsertarCurso(CursoCE objAlumn)
        {
            return ObjaCur.InsertarCurso(objAlumn);
        }
        public CursoCE ObtenerCursoId(int id)
        {
            return ObjaCur.ObtenerCursoId(id);
        }
        public bool EliminarCurso(int id)
        {
            return ObjaCur.EliminarCurso(id);
        }
        public bool ActualizarCurso(CursoCE cli)
        {
            return ObjaCur.ActualizarCurso(cli);
        }
    }
}
