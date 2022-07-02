using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()// Chamando index retorna View da Controller. Retorna a View acessa o HelloWorld tb
        {
            return View();
        }

        //GET: /HelloWorld/Welcome/
        public string Welcome(string nome, int vezes = 1, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"oi {nome}, vezes {vezes}, ID: {ID}");
        }

        public string Teste()// Aqui pode receber um parâmetro ex: nome
        {
            return "aqui pe só para mostrar como funciona a relação rota x método dentro da controller";
        }
    }
}
