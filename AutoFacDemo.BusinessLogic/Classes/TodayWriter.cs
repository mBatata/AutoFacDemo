using AutoFacDemo.BusinessLogic.Interfaces;
using System;

namespace AutoFacDemo.BusinessLogic.Classes
{
    public class TodayWriter : IDateWriter
    {
        private IOutput _output;
        private ILogger _logger;

        public TodayWriter(IOutput output, ILogger logger)
        {
            _output = output;
            _logger = logger;
        }

        public void WriteDate()
        {
            _logger.Log($"{nameof(TodayWriter)} START");
            _output.Write(DateTime.Today.ToShortDateString());
            _logger.Log($"{nameof(TodayWriter)} END");
        }
    }
}
