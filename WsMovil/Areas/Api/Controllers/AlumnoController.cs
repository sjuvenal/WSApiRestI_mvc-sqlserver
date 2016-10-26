using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaNegocio;
using CapaEntidad;

namespace WsMovil.Areas.Api.Controllers
{
    public class AlumnoController : Controller
    {
        AlumnoCN ObjAlum = new AlumnoCN();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult AlumnosTodos()
        {
            return Json(ObjAlum.ObtenerAlumnos(), JsonRequestBehavior.AllowGet);
        }


        public JsonResult Alumno(int? id, AlumnoCE item)
        {
            switch (Request.HttpMethod)
            {
                case "POST":

                    // true o false
                    return Json(ObjAlum.InsertarAlumno(item));

                case "PUT":
                    //retorna tru o false
                    return Json(ObjAlum.ActualizarAlumno(item));
                case "GET":
                    //http: //localhost:2088/Api/Clientes/Cliente/1  ACTION GET
                    return Json(ObjAlum.ObtenerAlumnoId(id.GetValueOrDefault()), JsonRequestBehavior.AllowGet);

                case "DELETE":

                    return Json(ObjAlum.EliminarAlumno(id.GetValueOrDefault()));
            }

            return Json(new { Error = true, Message = "Operacion Http desconocida" });
        } 

    }
}
