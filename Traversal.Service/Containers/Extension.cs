using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        }
    }
}
