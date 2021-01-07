using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_World.Services;
using The_World.ViewModel;

namespace The_World.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;

        public AppController(IMailService service)
        {
            _mailService = service;
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
        public IActionResult Contact(ContactViewModel model)
        {

            if (ModelState.IsValid)
            {
                var email = Startup.Configuration["AppSettings:SiteEmailAddress"];

                // if something is bad with the configuration retrieval
                if (string.IsNullOrWhiteSpace(email))
                {
                    ModelState.AddModelError("","Could not send mail, configuration problem");
                }

                // Sendmail function returns a bool
                if (_mailService.SendMail(
                    email,
                    email,
                    $"Contact Page from {model.Name} ({model.Email})", $"{model.Message}"))
                {
                    
                    ModelState.Clear();     // clearing the form

                    ViewBag.Message = "Mail sent. Thanks!";    // Message to the user from successfull sending
                } 
            }


            return View();
        }

    }
}
