using System;

namespace Rails.Api.Models.Journeys
{
    public class StartingPoint : Point, IDepart
    {
        public DateTime ScheduledDeparture { get; set; }
        public DateTime EstimatedDeparture { get; set; }
        public DateTime? ActualDeparture { get; set; }
        public JourneyStatus DepartureStatus { get; set; }
        public TransportType DepartureTransport { get; set; }
    }
}