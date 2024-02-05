using Microsoft.AspNetCore.Mvc;
using Traversal.Repository.EntityFramework;
using Traversal.Service.Concrete;

namespace Traversal.WEB.ViewComponents.Default
{
    public class _GridsPartial : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationRepository());

        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values); 
        }
            
    }
}
