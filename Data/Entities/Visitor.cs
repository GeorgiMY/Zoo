using System.ComponentModel.DataAnnotations;
using static Zoo.Data.lib.Enums;

namespace Zoo.Core
{
    public class Visitor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public VisitorTicketTypes TicketType { get; set; }

        [Required]
        public DateTime VisitDates { get; set; }
    }
}
