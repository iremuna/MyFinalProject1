using Core.IoC;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class ServicceCollectionsExtensions
    {
        //Extensions yazabilmek için classın static olması lazım

        public static IServiceCollection AddDependencyResolvers(this IServiceCollection service, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(ServiceCollection);
        }
    }
}
