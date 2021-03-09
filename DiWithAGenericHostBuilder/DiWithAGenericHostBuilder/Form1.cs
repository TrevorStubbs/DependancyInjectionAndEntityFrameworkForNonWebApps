using DiWithAGenericHostBuilder.Model.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiWithAGenericHostBuilder
{
    public partial class Form1 : Form
    {
        private readonly ILogger<Form1> _logger;
        private readonly IBusinessLayer _business;

        public Form1(ILogger<Form1> logger, IBusinessLayer business)
        {
            _logger = logger;
            _business = business;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation($"Form1 \"Started\" at {DateTime.UtcNow}.");
                _logger.LogWarning("Test Warning");
                _logger.LogError("Test Error");
                _logger.LogDebug("Test Debug");
                _logger.LogCritical("Test Critical");

                MessageBox.Show("Hello There welcome to my application");

                _logger.LogInformation($"Form1 \"Ended\" at {DateTime.UtcNow}.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
