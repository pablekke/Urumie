using Microsoft.AspNetCore.Mvc;
using Dominio.Controllers;


namespace WebAppRazor.Controllers
{
    public class UserController : Controller
    {
        Sistema s = Sistema.GetSistema();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            string? rol = HttpContext.Session.GetString("LogueadoRol");

            if (rol == "Admin")
            {
                return RedirectToAction("Publicaciones", "Publicacion");
            }

            if (rol != "Admin")
            {
                return RedirectToAction("Index", "User");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string pass)
        {
            Usuario? u = s.Login(email, pass);

            if (u != null)
            {
                HttpContext.Session.SetInt32("LogueadoId", u.Id);

                HttpContext.Session.SetString("LogueadoNombreApellido", u.Nombre + " " + u.Apellido);
                HttpContext.Session.SetString("LogueadoRolUsuario", u.GetType().Name);
                if (u is Miembro)
                {
                    if (u is Inquilino) {
                        HttpContext.Session.SetString("LogueadoRolMiembro", "Inquilino");
                    }
                    if (u is Propietario)
                    {
                        HttpContext.Session.SetString("LogueadoRolMiembro", "Propietario");
                    }
                }

                if (u is Miembro)
                {
                    return RedirectToAction("Index", "Publicacion");
                }
                return RedirectToAction("BuscarPublicaciones", "Publicacion");

            }
            else
            {
                ViewBag.msg = "Usuario y/o contraseña incorrectos";
                return View();
            }
        }

    }
}
