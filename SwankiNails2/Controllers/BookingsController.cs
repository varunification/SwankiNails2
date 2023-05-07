using Microsoft.AspNetCore.Mvc;
using SwankiNails2.Models;
using SwankiNails2.utility;
using System.Diagnostics;

namespace SwankiNails2.Controllers
{
    public class BookingsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmailProvider _emailProvider;
        public BookingsController(ILogger<HomeController> logger, EmailProvider emailProvider)
        {
            _logger = logger;
            _emailProvider= emailProvider;
        }

        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(BookingViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Do something with the form data, e.g. save it to a database
                // Redirect to a thank-you page or display a success message
               // Console.WriteLine(model.Name + model.Email + model.Mobile + model.Service);
                emailsender dm = new(_emailProvider._connectionString, model);
                emailsender dm1= new(_emailProvider._connectionString, model);
                return RedirectToAction("ThankYou");
            }
            else
            {
                return View(model);
            }
        }
       
        public IActionResult serviceForm(string service)
        {
            ViewBag.service = service;
            return View();
        }


        public IActionResult ThankYou()
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