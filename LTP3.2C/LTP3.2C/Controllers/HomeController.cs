using LTP3._2C.Models;
using LTP3._2C.Repositorrys;
using Microsoft.AspNetCore.Mvc;

namespace LTP3._2C.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepositorry _rep;
        public HomeController(IBookRepositorry rep)
        {
            _rep = rep;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Book book)
        {
            _rep.Adiciona(book);
            return RedirectToAction("Listas");
        }
        public IActionResult Listas()
        {
            return View(_rep.Lista());
        }
    }
}