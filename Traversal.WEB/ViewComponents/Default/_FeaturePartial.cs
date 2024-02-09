using Microsoft.AspNetCore.Mvc;
using Traversal.Repository.EntityFramework;
using Traversal.Service.Concrete;

namespace Traversal.WEB.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureRepository());

        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View(values); 
        }
    }
}
