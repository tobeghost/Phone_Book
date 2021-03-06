using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using PhoneBook.Core.Models;
using PhoneBook.Web.Services;

namespace PhoneBook.Web.Extensions
{
    public static class ServiceExtension
    {
        public static void AddHttpClientServices(this IServiceCollection services, IConfiguration Configuration)
        {
            var serviceApiSettings = Configuration.GetSection("ServiceApiSettings").Get<ServiceApiSettings>();

            services.AddHttpClient<IReportService, ReportService>(opt =>
            {
                opt.BaseAddress = new Uri($"{serviceApiSettings.GatewayBaseUri}/{serviceApiSettings.Report.Path}");
            });
            services.AddHttpClient<IContactService, ContactService>(opt =>
            {
                opt.BaseAddress = new Uri($"{serviceApiSettings.GatewayBaseUri}/{serviceApiSettings.Book.Path}");
            });
            services.AddHttpClient<IUserService, UserService>(opt =>
            {
                opt.BaseAddress = new Uri($"{serviceApiSettings.GatewayBaseUri}/{serviceApiSettings.Book.Path}");
            });
        }
    }
}
