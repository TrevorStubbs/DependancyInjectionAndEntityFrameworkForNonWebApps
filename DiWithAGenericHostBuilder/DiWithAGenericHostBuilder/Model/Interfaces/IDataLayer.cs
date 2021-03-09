using System;
using System.Collections.Generic;
using System.Text;

namespace DiWithAGenericHostBuilder.Model.Interfaces
{
    public interface IDataLayer
    {
        public void ShowData()
        {
            Console.WriteLine("I am data");
        }
    }
}
