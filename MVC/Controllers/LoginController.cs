using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Mail, string Password)
        {
            Sistema unS = Sistema.Instancia;
            Cliente? unC = unS.DevolverCliente(Mail,Password);
            if(unC != null)
            {
                HttpContext.Session.SetString("Mail", unC.Mail);
                HttpContext.Session.SetString("Rol", unC.GetType().ToString());
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.Mensaje = "Credenciales incorrectas"; 
                return View();
            }

        }

        
    }
}
