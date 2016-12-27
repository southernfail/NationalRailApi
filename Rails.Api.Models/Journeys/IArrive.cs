using System;

namespace Rails.Api.Models.Journeys
{
    public interface IArrive : IPoint
    {
        DateTime ScheduledArrival { get; set; }
        DateTime EstimatedArrival { get; set; }
        DateTime? ActualArrival { get; set; }
        JourneyStatus ArrivalStatus { get; set; }
        TransportType ArrivalTransport { get; set; }
    }
}