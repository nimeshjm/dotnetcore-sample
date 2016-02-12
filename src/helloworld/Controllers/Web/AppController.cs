using helloworld.Services;
using helloworld.ViewModels;
using Microsoft.AspNet.Mvc;

namespace helloworld.Controllers.Web
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            this._mailService = mailService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel contactViewModel)
        {
            return View();
        }
    }
}