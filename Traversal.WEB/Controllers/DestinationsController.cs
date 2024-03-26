using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.Core.Concrete;
using Traversal.Repository.EntityFramework;
using Traversal.Service.Abstract;
using Traversal.Service.Concrete;

namespace Traversal.WEB.Controllers
{
    [AllowAnonymous]
    public class DestinationsController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationsController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }

        //destination rotaların id göre seçtiğimizde onu getiricek.
        [HttpGet]
        public IActionResult DestinationDetails(int id) 
        { 
            ViewBag.i = id;
            var values = _destinationService.TGetByID(id);
            return View(values);
        }

        
    }
}
