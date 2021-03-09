using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiInConsoleApp
{
    public class MyApplication : IMyApplication
    {
        private readonly ILogger _logger;

        public MyApplication(ILogger<MyApplication> logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.LogInformation($"Application Started at {DateTime.Now}");

            _logger.LogInformation($"Application Ended at {DateTime.Now}");
        }
    }
}
