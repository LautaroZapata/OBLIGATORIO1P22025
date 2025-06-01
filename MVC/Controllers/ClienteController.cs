using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VerVuelos()
        {
            Sistema unS = Sistema.Instancia;
            List<Vuelo> lista = unS.ListarVuelos();
            ViewBag.ListaVuelos = lista;
            if(lista.Count == 0)
            {
                ViewBag.error = "Lista vacia";
            }
            return View();
        }
        public IActionResult VerPasajes()
        {
            Sistema unS = Sistema.Instancia;
            List<Pasaje> listaP = unS.ListarPasajes();
            ViewBag.ListaPasajes = listaP;
            if(listaP.Count == 0)
            {
                ViewBag.error = "Lista vacia";
            }
            return View();
        }
    }
}
