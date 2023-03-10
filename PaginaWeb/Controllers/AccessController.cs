using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginaWeb.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {

            return View();

        }

        public ActionResult Enter(string user, string password)
        {
            try
            {
                using (cursomvcEntities db = new cursomvcEntities())
                {

                    //con Linq consulto directamente en la base de datos
                    var lst = from d in db.user
                              where d.email == user && d.password == password && d.idState == 1
                              select d;
                    //para calidar que si hay algun usuario con ese email, password y este activo
                    if (lst.Count() > 0)
                    {
                        //si existe el usuario, creamos una sesion
                        user oUser = lst.First();
                        Session["User"] = oUser;
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario invalido ...");
                    }

                }

            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error :(" + ex.Message);
            }
        }

    }
}