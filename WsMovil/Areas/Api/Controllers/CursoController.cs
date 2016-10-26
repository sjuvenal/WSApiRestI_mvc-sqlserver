using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaNegocio;
using CapaEntidad;

namespace WsMovil.Areas.Api.Controllers
{
    public class CursoController : Controller
    {
        CursoCN ObjAlum = new CursoCN();
        //
        // GET: /Api/Curso/

        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public JsonResult CursoTodos()
        {
            return Json(ObjAlum.ObtenerCursos(), JsonRequestBehavior.AllowGet);
        }


        public JsonResult Curso(int? id, CursoCE item)
        {
            switch (Request.HttpMethod)
            {
                case "POST":

                    // true o false
                    return Json(ObjAlum.InsertarCurso(item));

                case "PUT":
                    //retorna tru o false
                    return Json(ObjAlum.ActualizarCurso(item));
                case "GET":
                    //http: //localhost:2088/Api/Clientes/Cliente/1  ACTION GET
                    return Json(ObjAlum.ObtenerCursoId(id.GetValueOrDefault()), JsonRequestBehavior.AllowGet);

                case "DELETE":

                    return Json(ObjAlum.EliminarCurso(id.GetValueOrDefault()));
            }

            return Json(new { Error = true, Message = "Operacion Http desconocida" });
        } 

    }
}
