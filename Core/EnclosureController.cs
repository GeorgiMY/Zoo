using Zoo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core
{
    public class EnclosureController
    {
        public ZooContext context { get; set; }
        public EnclosureController()
        {
            context = new ZooContext();
        }

        public List<string> GetEnclosureNames()
        {
            List<string> allEnclosureNames = context.Enclosures.Select(x => x.Name).ToList();

            return allEnclosureNames;
        }
    }
}
