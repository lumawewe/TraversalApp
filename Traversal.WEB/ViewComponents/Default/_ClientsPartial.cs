using Microsoft.AspNetCore.Mvc;
using Traversal.Repository.EntityFramework;
using Traversal.Service.Concrete;

namespace Traversal.WEB.ViewComponents.Default
{
    public class _ClientsPartial : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialRepository());

        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}
