using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core
{
    public class EmployeeController
    {
        public ZooContext context { get; set; }
        public EmployeeController()
        {
            context = new ZooContext();
        }

        public List<string> GetEmployeeNames()
        {
            List<string> allEmployeeNames = context.Employees.Select(x => x.Name).ToList();

            return allEmployeeNames;
        }
    }
}
