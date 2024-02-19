using Microsoft.AspNetCore.Mvc;
using Traversal.Core.Concrete;
using Traversal.Repository.EntityFramework;
using Traversal.Service.Concrete;

namespace Traversal.WEB.Controllers
{
    public class DestinationsController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationRepository());
        
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id) 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination d)
        {
            return View();  
        }
    }
}
