using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Zoo.Data.lib.Enums;

namespace Zoo.Data.Entities
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int SpeciesId { get; set; }

        [Required]
        public Species Species { get; set; }

        [Required]
        public bool Gender { get; set; }

        [Required]
        public DateTime DateArrived { get; set; }

        [Required]
        public AnimalHealthStatuses HealthStatus { get; set; }

        [Required]
        public int EnclosureId { get; set; }
        
        [Required]
        public Enclosure Enclosure { get; set; }
    }
}
