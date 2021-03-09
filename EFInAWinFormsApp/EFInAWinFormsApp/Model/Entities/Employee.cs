using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFInAWinFormsApp.Model.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
