using System.ComponentModel.DataAnnotations;
using Zoo.Data.Entities;
using static Zoo.Data.lib.Enums;

namespace Zoo.Core
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Species SpeciesId { get; set; }

        [Required]
        public bool Gender { get; set; }

        [Required]
        public DateTime DateArrived { get; set; }
        [Required]
        public AnimalHealthStatuses HealthStatus { get; set; }
        [Required]
        public Enclosure EnclosureId { get; set; }
    }
}
