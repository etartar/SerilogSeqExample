using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace SerilogSeqExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogInformation("Hello first log in HomeController Constructor.");
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            _logger.LogInformation("Hello first log in HomeControler GetAll Action");

            var name = "Emir";

            _logger.LogInformation("Hello {Name}", name);

            var caretta = new
            {
                Name = "Caretta Yazılım",
                Adress = "Istanbul / Mecidiyeköy",
                Employees = new object []
                {
                    new
                    {
                        FullName = "Emir TARTAR"
                    },
                    new
                    {
                        FullName = "Eray ONUR"
                    }
                }
            };

            _logger.LogInformation("{@Caretta}", caretta);

            throw new ArgumentException("caretta is null");

            return Ok(true);
        }
    }
}
