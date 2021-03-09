using AddingEFToANonASPProgram.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddingEFToANonASPProgram.Model.Services
{
    class HelloService : IHello
    {
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
