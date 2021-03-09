using DiInAWinFormsApp.Model;
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

namespace DiInAWinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly ILogger<Form1> _logger;
        private readonly IBusinessLayer _business;

        public Form1(IBusinessLayer business, ILogger<Form1> logger)
        {
            _logger = logger;
            _business = business;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation($"Form1 Started at {DateTime.Now}.");

                _business.IAmBusiness();

                MessageBox.Show("Hello .NET 5.0. This is First Form app in .NET Core");

                _logger.LogInformation($"Form1 Ended at {DateTime.Now}.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
