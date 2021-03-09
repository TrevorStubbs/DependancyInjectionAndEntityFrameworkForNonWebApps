using DiWithAGenericHostBuilder.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiWithAGenericHostBuilder.Model.Services
{
    public class BusinessLayer : IBusinessLayer
    {
        public void DoBusiness()
        {
            Console.WriteLine("I am important business");
        }
    }
}
