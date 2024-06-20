using Microsoft.AspNetCore.Mvc;

namespace CadastroClientes.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
