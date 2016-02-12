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
            if (ModelState.IsValid)
            {
                var email = Startup.Configuration["AppSettings:SiteEmailAddress"];

                if (string.IsNullOrEmpty(email))
                {
                    ModelState.AddModelError("", "Could not read email from configuration.");
                }

                var emailSent = _mailService.SendMail(
                    email,
                    email,
                    $"Contact from {contactViewModel.Name} ({contactViewModel.Email})",
                    contactViewModel.Message);

                if (emailSent)
                {
                    ModelState.Clear();

                    ViewBag.Message = "Email Sent.";
                }
            }

            return View();
        }
    }
}