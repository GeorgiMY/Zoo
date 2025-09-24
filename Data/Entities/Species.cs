using System.ComponentModel.DataAnnotations;
using static Zoo.Data.lib.Enums;

namespace Zoo.Data.Entities
{
    public class Species
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string RegularName { get; set; }
        
        [Required]
        public string ScientificName { get; set; }

        [Required]
        public SpeciesConservationStatuses ConservationStatus { get; set; }

        [Required]
        public SpeciesDietTypes DietType { get; set; }

        [Required]
        public int AverageLifespan { get; set; }
    }
}
