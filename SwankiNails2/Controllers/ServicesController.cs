using Microsoft.AspNetCore.Mvc;

namespace SwankiNails2.Controllers
{
    public class ServicesController: Controller
    {
        private readonly ILogger<ServicesController> _logger;

        public ServicesController(ILogger<ServicesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Products()
        {
            return View();
        }

    }
}
