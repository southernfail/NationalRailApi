using System;

namespace Rails.Api.Models.Journeys
{
    public class Stop : Point, IStop
    {
        public DateTime ScheduledArrival { get; set; }
        public DateTime EstimatedArrival { get; set; }
        public DateTime? ActualArrival { get; set; }
        public JourneyStatus ArrivalStatus { get; set; }
        public TransportType ArrivalTransport { get; set; }

        public DateTime ScheduledDeparture { get; set; }
        public DateTime EstimatedDeparture { get; set; }
        public DateTime? ActualDeparture { get; set; }
        public JourneyStatus DepartureStatus { get; set; }
        public TransportType DepartureTransport { get; set; }
    }
}