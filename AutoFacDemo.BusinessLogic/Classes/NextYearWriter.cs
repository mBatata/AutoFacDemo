using AutoFacDemo.BusinessLogic.Interfaces;
using System;

namespace AutoFacDemo.BusinessLogic.Classes
{
    public class NextYearWriter : IDateWriter
    {
        private IOutput _output;
        private ILogger _logger;

        public NextYearWriter(IOutput output, ILogger logger)
        {
            _output = output;
            _logger = logger;
        }

        public void WriteDate()
        {
            _logger.Log($"{nameof(NextYearWriter)} START");
            _output.Write(DateTime.Today.AddYears(1).ToShortDateString());
            _logger.Log($"{nameof(NextYearWriter)} END");
        }
    }
}
