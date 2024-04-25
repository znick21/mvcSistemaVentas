using Microsoft.AspNetCore.Mvc;

namespace mvcSistemaVentas.Areas.Admin.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
