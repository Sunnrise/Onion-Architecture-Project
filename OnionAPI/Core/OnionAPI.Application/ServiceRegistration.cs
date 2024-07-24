using Microsoft.Extensions.DependencyInjection;
using OnionAPI.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using System.Globalization;
using MediatR;
using OnionAPI.Application.Behaviours;
using OnionAPI.Application.Features.Rules;
using OnionAPI.Application.Bases;

namespace OnionAPI.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddTransient<ExceptionMiddleware>();

            services.AddRulesFromAssemblyContaining(assembly, typeof(BaseRules));

            services.AddMediatR(configuration=> configuration.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);

            ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("en");
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehaviour<,>));
        }

        public static IServiceCollection AddRulesFromAssemblyContaining(this IServiceCollection services, Assembly assembly, Type type)
        {
            var types = assembly.GetTypes().Where(x => x.IsSubclassOf(type)&& type is not null).ToList();
            foreach (var item in types)
            {
                services.AddTransient(item);
            }
            return services;
        }
    }
}
