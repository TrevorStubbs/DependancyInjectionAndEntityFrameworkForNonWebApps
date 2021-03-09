using EFInAWinFormsApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFInAWinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly EmployeeDbContext _context;

        public Form1(EmployeeDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void GetEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = _context.Employees.FirstOrDefault(x => x.EmployeeId == 1);
                MessageBox.Show($"The Employee's name is: {employee.FirstName} {employee.LastName}.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
