using System;
using Rails.Api.Models;
using Rails.Api.Models.Journeys;
using Rails.Api.Models.Timing;

namespace Rails.Utilities.Delay
{
    public static class TimingExtensions
    {
        public static TimingInformation CalculateDelay(this Journey journey, Station from, Station to)
        {
            var calc = new TimingCalculator(journey);

            return new TimingInformation
            {
                Journey = journey,
                
            };
        }

        public static TimeSpan GetDelay(this IArrive arrivalPoint)
        {
            return (arrivalPoint.ActualArrival ?? arrivalPoint.EstimatedArrival) - arrivalPoint.ScheduledArrival;
        }

    }
}
