using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SwaggerWebAPI.Models;
namespace SwaggerWebAPI
{
    public static class IOCConfiguration
    {
        //This Extension Method of IServiceCollection type
        public static IServiceCollection IOCRegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
            // and a lot more Services
            return services;
        }
        // public static void IOCRegisterServices(IServiceCollection services)
        // {
        //     services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
        //     // and a lot more Services
        // }
    }
}