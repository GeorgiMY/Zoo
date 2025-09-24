using System.ComponentModel.DataAnnotations;
using static Zoo.Data.lib.Enums;

namespace Zoo.Core
{
    public class Enclosure
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public EnclosureTypes Types { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public EnclosureLocations Locations { get; set; }
    }
}
