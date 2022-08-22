using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria()
            {
                Id = 2,
                Nome = "Fernando"
            },
            new Categoria()
            {
                Id=3,
                Nome = "Fernanda"
            }
        };

        public IActionResult Index()
        {
            return View(categorias);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}