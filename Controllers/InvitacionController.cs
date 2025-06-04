using Microsoft.AspNetCore.Mvc;

namespace TuProyecto.Controllers
{
    public class InvitacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Confirmacion()
        {
            return View(); // Carga Confirmacion.cshtml
        }

        public IActionResult Confirmado()
        {
            return View(); // Carga Confirmado.cshtml
        }
    }
}
