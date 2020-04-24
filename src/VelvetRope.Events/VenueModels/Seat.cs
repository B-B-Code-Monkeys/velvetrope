using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VelvetRope.Events.VenueModels
{
    public class Seat
    {
        [Key]
        public Guid SeatId { get; set; }
        public Guid VenueId { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public string Section { get; set; }
    }
}
