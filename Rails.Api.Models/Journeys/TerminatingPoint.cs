using System;

namespace Rails.Api.Models.Journeys
{
    public class TerminatingPoint : Point, IArrive
    {
        public DateTime ScheduledArrival { get; set; }
        public DateTime EstimatedArrival { get; set; }
        public DateTime? ActualArrival { get; set; }
        public JourneyStatus ArrivalStatus { get; set; }
        public TransportType ArrivalTransport { get; set; }
    }
}