using Autofac;
using AutoFacDemo.BusinessLogic.Classes;
using AutoFacDemo.BusinessLogic.Enums;
using AutoFacDemo.BusinessLogic.Interfaces;
using System;

namespace AutoFacDemo
{
    public class DateWriterModule : Module
    {
        public DateWriterType DateWriterType { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<ConsoleLogger>().As<ILogger>();

            switch (DateWriterType)
            {
                case DateWriterType.Today:
                    builder.RegisterType<TodayWriter>().As<IDateWriter>();
                    break;

                case DateWriterType.Tomorrow:
                    builder.RegisterType<TomorrowWriter>().As<IDateWriter>();
                    break;

                case DateWriterType.NextWeek:
                    builder.RegisterType<NextWeekWriter>().As<IDateWriter>();
                    break;

                case DateWriterType.NextMonth:
                    builder.RegisterType<NextMonthWriter>().As<IDateWriter>();
                    break;

                case DateWriterType.NextYear:
                    builder.RegisterType<NextYearWriter>().As<IDateWriter>();
                    break;

                default:
                    throw new NotImplementedException($"Type {DateWriterType} not implemented");
            }

            base.Load(builder);
        }
    }
}
