using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebDemo.Resources;

namespace WebDemo.Controllers
{
    public class CustomerController : Controller
    {
        private readonly LocalizationService _localizationService;

        public CustomerController(LocalizationService localizationService)
        {
            _localizationService = localizationService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var fullName = _localizationService.GetLocalizedHtmlString("FullName");
            var city = _localizationService.GetLocalizedHtmlString("City");
            var mobileno = _localizationService.GetLocalizedHtmlString("MobileNo");

            return View();
        }
    }
}
