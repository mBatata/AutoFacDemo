using Autofac;
using AutoFacDemo.BusinessLogic.Classes;
using AutoFacDemo.BusinessLogic.Interfaces;

namespace AutoFacDemo
{
    internal static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<ConsoleOutput>().As<IOutput>();
            containerBuilder.RegisterType<TodayWriter>().As<IDateWriter>();

            return containerBuilder.Build();
        }
    }
}
