using Microsoft.Extensions.DependencyInjection;
using Traversal.Repository.Abstract;
using Traversal.Repository.EntityFramework;
using Traversal.Service.Abstract;
using Traversal.Service.Concrete;

namespace Traversal.Service.Containers
{
    public static class Extension
    {
        public static void ContainerDepedencies(this IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentRepository, EfCommentRepository>();

            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationRepository, EfDestinationRepository>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserRepository, EfAppUserRepository>();
            
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationRepository, EfReservationRepository>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideRepository, EfGuideRepository>();

            services.AddScoped<IExcelService, ExcelManager>();

            services.AddScoped<IPdfService, PdfManager>();


        }
    }
}
