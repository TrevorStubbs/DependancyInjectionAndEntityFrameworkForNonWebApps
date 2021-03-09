using DiInAWinFormsApp.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiInAWinFormsApp.Model.Services
{
    public class DataLayer : IDataLayer
    {
        public string IAmData()
        {
            return "I am Data";
        }
    }
}
