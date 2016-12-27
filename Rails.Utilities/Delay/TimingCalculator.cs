using System;
using System.Linq;
using Rails.Api.Models;
using Rails.Api.Models.Journeys;
using Rails.Api.Models.Timing;

namespace Rails.Utilities.Delay
{
    internal class TimingCalculator
    {
        private readonly Journey _journey;

        public TimingCalculator(Journey journey)
        {
            _journey = journey;
        }

        public TimingInformation CalculateArrival(Station to)
        {
            IArrive arrivalPoint;

            if (_journey.Arrives.Station == to)
            {
                arrivalPoint = _journey.Arrives;
            }
            else
            {
                arrivalPoint = _journey.Stops.Single(s => s.Station == to);
            }

            var timing = (arrivalPoint.ActualArrival ?? arrivalPoint.EstimatedArrival) - arrivalPoint.ScheduledArrival;

            return new TimingInformation
            {
                Journey = _journey,
                PointOnJourney = arrivalPoint,
                TimingDiffernece = timing,
                Type = timing < TimeSpan.Zero ? TimingType.Late : TimingType.Early
            };
        }

        public TimingInformation CalculateDeparture(Station from)
        {
            IDepart departurePoint;

            if (_journey.Departs.Station == from)
            {
                departurePoint = _journey.Departs;
            }
            else
            {
                departurePoint = _journey.Stops.Single(s => s.Station == from);
            }

            var timing = (departurePoint.ActualDeparture ?? departurePoint.EstimatedDeparture) - departurePoint.ScheduledDeparture;

            return new TimingInformation
            {
                Journey = _journey,
                PointOnJourney = departurePoint,
                TimingDiffernece = timing,
                Type = timing < TimeSpan.Zero ? TimingType.Late : TimingType.Early
            };
        }

    }
}
