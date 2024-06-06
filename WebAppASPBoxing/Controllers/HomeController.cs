using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppASPBoxing.Models;

namespace WebAppASPBoxing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        [HttpPost]
        public IActionResult GetClientMessage(ClientMessage clientMessage)
        {
            // 2. ��������� � ��
            if (ModelState.IsValid)
            {
                return View("Succes", clientMessage);             // �����, ������ �������
            }
            else
            {
                return View("Error", clientMessage);            // �������, ������ �� �������
            }
        }
    }
}
