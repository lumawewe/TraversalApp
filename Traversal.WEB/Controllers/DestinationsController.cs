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

        //destination rotaların id göre seçtiğimizde onu getiricek.
        [HttpGet]
        public IActionResult DestinationDetails(int id) 
        { 
            ViewBag.i = id;
            var values = destinationManager.TGetByID(id);
            return View(values);
        }

        
    }
}
