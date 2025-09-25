using Zoo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core
{
    public class SpeciesController
    {
        public ZooContext context { get; set; }
        public SpeciesController()
        {
            context = new ZooContext();
        }

        public List<string> GetSpeciesNames()
        {
            List<string> allSpeciesNames = context.Species.Select(x => x.ScientificName).ToList();

            return allSpeciesNames;
        }
    }
}
