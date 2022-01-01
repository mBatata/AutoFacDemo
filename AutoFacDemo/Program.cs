using Autofac;
using AutoFacDemo.BusinessLogic.Interfaces;
using System;

namespace AutoFacDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var container = ContainerConfig.Configure();

                using (var scope = container.BeginLifetimeScope())
                {
                    var writer = scope.Resolve<IDateWriter>();
                    writer.WriteDate();
                }

                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
