﻿using System;

namespace Rails.Api.Models.Journeys
{
    public interface IDepart
    {
        Station Station { get; set; }
        DateTime ScheduledDeparture { get; set; }
        DateTime EstimatedDeparture { get; set; }
        DateTime? ActualDeparture { get; set; }
        JourneyStatus DepartureStatus { get; set; }
        TransportType DepartureTransport { get; set; }
    }
}