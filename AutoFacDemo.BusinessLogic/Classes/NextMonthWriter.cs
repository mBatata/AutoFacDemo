using AutoFacDemo.BusinessLogic.Interfaces;
using System;

namespace AutoFacDemo.BusinessLogic.Classes
{
    public class NextMonthWriter : IDateWriter
    {
        private IOutput _output;
        private ILogger _logger;

        public NextMonthWriter(IOutput output, ILogger logger)
        {
            _output = output;
            _logger = logger;
        }

        public void WriteDate()
        {
            _logger.Log($"{nameof(NextMonthWriter)} START");
            _output.Write(DateTime.Today.AddMonths(1).ToShortDateString());
            _logger.Log($"{nameof(NextMonthWriter)} END");
        }
    }
}
