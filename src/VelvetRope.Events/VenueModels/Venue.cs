using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VelvetRope.Events.VenueModels
{
    public class Venue
    {
        [Key]
        public Guid VenueId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxSeatingCapacity { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
    }
}
