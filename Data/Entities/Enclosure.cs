using System.ComponentModel.DataAnnotations;
using static Zoo.Data.lib.Enums;

namespace Zoo.Data.Entities
{
    public class Enclosure
    {
        [Key]
        public int Id { get; set; }

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
