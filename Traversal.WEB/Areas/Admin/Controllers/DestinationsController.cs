using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.Core.Concrete;
using Traversal.Repository.EntityFramework;
using Traversal.Service.Abstract;
using Traversal.Service.Concrete;

namespace Traversal.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationsController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationRepository());

        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(Destination d)
        {
            destinationManager.TAdd(d);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination d)
        {
            return View();
        }

        public IActionResult DeleteDestination()
        {
            return View();  
        }

    }
}
