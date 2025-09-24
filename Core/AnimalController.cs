using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core
{
    public class AnimalController
    {
        public ZooContext context {  get; set; }
        public AnimalController()
        {
            context = new ZooContext();
        }

        public List<string> GetAnimalNames()
        {
            List<string> allAnimalNames = context.Animals.Select(x => x.Name).ToList();

            return allAnimalNames;
        }
    }
}
