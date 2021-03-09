using DiWithAGenericHostBuilder.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiWithAGenericHostBuilder.Model.Services
{
    public class DataLayer : IDataLayer
    {
        public void ShowData()
        {
            Console.WriteLine("I am important business");
        }
    }
}
