using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core
{
    public class VisitorController
    {
        public ZooContext context { get; set; }
        public VisitorController()
        {
            context = new ZooContext();
        }

        public List<string> GetVisitorNames()
        {
            List<string> allVisitorNames = context.Visitors.Select(x => x.Name).ToList();

            return allVisitorNames;
        }
    }
}
