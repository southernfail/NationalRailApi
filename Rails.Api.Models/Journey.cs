using System.Collections.Generic;
using Rails.Api.Models.Journeys;

namespace Rails.Api.Models
{
    public class Journey
    {
        public string Identifier { get; set; }
        public StartingPoint Departs { get; set; }
        public TerminatingPoint Arrives { get; set; }
        public IEnumerable<IStop> Stops { get; set; }
        public Reason CancellationReason { get; set; }
        public Reason DelayReason { get; set; }
        public JourneyStatus Status { get; set; }
    }
}
