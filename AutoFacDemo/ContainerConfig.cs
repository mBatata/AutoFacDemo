using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AutoFacDemo
{
    internal static class ContainerConfig
    {
        #region Old Code
        //public static IContainer Configure()
        //{
        //    var containerBuilder = new ContainerBuilder();

        //    containerBuilder.RegisterType<ConsoleOutput>().As<IOutput>();
        //    containerBuilder.RegisterType<TodayWriter>().As<IDateWriter>();
        //    containerBuilder.RegisterType<ConsoleLogger>().As<ILogger>();

        //    return containerBuilder.Build();
        //} 
        #endregion

        public static IContainer Configure()
        {
            // Load Configuration Data
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path: "autofac.json", optional: false, reloadOnChange: true);

            var configuration = configurationBuilder.Build();

            // Load Container Configuration
            var builder = new ContainerBuilder();

            builder.RegisterModule(new ConfigurationModule(configuration));

            return builder.Build();
        }
    }
}
