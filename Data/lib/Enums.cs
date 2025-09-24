namespace Zoo.Data.lib
{
    public class Enums
    {
        public enum SpeciesConservationStatuses
        {
            LeastConcern,
            NearThreatened,
            Vulnerable,
            Endangered,
            CriticallyEndangered,
            ExtinctInTheWild,
            Extinct
        }

        public enum SpeciesDietTypes
        {
            Herbivore,
            Carnivore,
            Omnivore,
            Insectivore,
            Piscivore,
            Frugivore,
            Nectarivore
        }

        public enum AnimalHealthStatuses
        {
            Healthy,
            Sick,
            Injured,
            UnderObservation,
            Recovering,
            Quarantined,
            Deceased
        }

        public enum VisitorTicketTypes
        {
            Adult,
            Child,
            Senior,
            Student,
            Group,
            AnnualPass,
            VIP
        }

        public enum EmployeeRoles
        {
            Zookeeper,
            Veterinarian,
            Guide,
            TicketSeller,
            Administrator,
            Maintenance,
            Cleaner,
            Security
        }

        public enum EnclosureTypes
        {
            Aquarium,
            Aviary,
            Terrarium,
            Safari,
            Savanna,
            Rainforest,
            Desert,
            PettingZoo,
            Insectarium,
            Amphitheater,
            MixedHabitat
        }

        public enum EnclosureLocations
        {
            NorthZone,
            SouthZone,
            EastZone,
            WestZone
        }
    }
}
