using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSolveProperties.Application.Interfaces;

using iSolveProperties.Application.Mapping;
using iSolveProperties.Application.Services;
using iSolveProperties.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace iSolveProperties.Infrastructure.DIConfigration
{
   public class ServiceModule
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IRealtorRepository, RealtorRepository>();
            services.AddScoped<IRealtorService, RealtorService>();
            services.AddScoped<IBusinessPartnerService, BusinessPartnerService>();
            services.AddScoped<IBusinessPartnerRepository, BusinessPartnerRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectInventoryRepository, ProjectInventoryRepository>();
            services.AddScoped<IProjectInventoryService, ProjectInventoryService>();
            services.AddScoped<IEventReportRepository, EventReportRepository>();
            services.AddScoped<IEventReportService, EventReportService>();
            services.AddScoped<IBDMChangeRequestService, BDMChangeRequestService>();
            services.AddScoped<IBDMChangeRequestRepository, BDMChangeRequestRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IBookingService, BookingService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}
