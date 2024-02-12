using Microsoft.AspNetCore.Mvc;
using Traversal.Repository.EntityFramework;
using Traversal.Service.Concrete;

namespace Traversal.WEB.ViewComponents.Default
{
    public class _SubAboutsPartial : ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutRepository());
        
        public IViewComponentResult Invoke() 
        {
            var values = subAboutManager.TGetList();
            return View(values); 
        }
    }
}
