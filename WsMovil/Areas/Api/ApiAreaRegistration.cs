using System.Web.Mvc;

namespace WsMovil.Areas.Api
{
    public class ApiAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Api";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {

            context.MapRoute(
             "AccesoAlumnocrud",
             "Api/alumnos/crup/{id}",
             new { Controller = "Alumno", action = "Alumno", id = UrlParameter.Optional }
             );

            //ACCDER AL LISTADO DE CLIENTES
            context.MapRoute(
                "AccesoAlumnos",
                "Api/alumnos",
                new { Controller = "Alumno", action = "AlumnosTodos" }
                );

            //accder a los cursos

            context.MapRoute(
             "AccesoCursocrud",
             "Api/curso/crup/{id}",
             new { Controller = "Curso", action = "Curso", id = UrlParameter.Optional }
             );


            context.MapRoute(
              "AccesoCurso",
              "Api/Cursos",
              new { Controller = "Curso", action = "CursoTodos" }
              );



            context.MapRoute(
                "Api_default",
                "Api/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );






        }
    }
}
