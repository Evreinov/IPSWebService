using Microsoft.AspNetCore.Mvc;
using WebIPS.Interfaces.ValuesAPI;

namespace WebIPS.Controllers
{
    public class WebApiController : Controller
    {
        private readonly IValuesService _ValuesService;
        public WebApiController(IValuesService ValuesService) => _ValuesService = ValuesService;

        public IActionResult Index()
        {
            var values = _ValuesService.Get();
            return View(values);
        }
    }
}
