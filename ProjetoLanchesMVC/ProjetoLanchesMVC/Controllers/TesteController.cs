using Microsoft.AspNetCore.Mvc;

namespace ProjetoLanchesMVC.Controllers
{
    public class TesteController : Controller
    {
        public string Index()
        {
            return $"Testando o método Index de TesteController : {DateTime.Now}";
        }
    }
}
