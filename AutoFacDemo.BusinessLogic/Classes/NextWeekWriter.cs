using AutoFacDemo.BusinessLogic.Interfaces;
using System;

namespace AutoFacDemo.BusinessLogic.Classes
{
    public class NextWeekWriter : IDateWriter
    {
        private IOutput _output;
        private ILogger _logger;

        public NextWeekWriter(IOutput output, ILogger logger)
        {
            _output = output;
            _logger = logger;
        }

        public void WriteDate()
        {
            _logger.Log($"{nameof(NextWeekWriter)} START");
            _output.Write(DateTime.Today.AddDays(7).ToShortDateString());
            _logger.Log($"{nameof(NextWeekWriter)} END");
        }
    }
}
