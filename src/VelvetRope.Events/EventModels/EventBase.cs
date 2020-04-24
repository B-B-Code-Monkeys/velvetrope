using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VelvetRope.Events.EventModels
{
    public class EventBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid EventId { get; set; }
        public Guid VenueId { get; set; }
        public string Name { get; set; }
        public DateTime StartDateTimeUtc { get; set; }
        public EventType EventType { get; set; }
    }
}
