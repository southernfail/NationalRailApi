using System;
using System.Collections.Generic;
using System.Linq;
using Rails.Api.Models;
using Rails.Api.Models.Journeys;

namespace Rails.Utilities.Delay
{
    internal class DelayCalculator
    {
        private readonly Journey _journey;

        public DelayCalculator(Journey journey)
        {
            _journey = journey;
        }

        public TimeSpan CalculateDelay(Station from, Station to)
        {
            

            var deptTime = GetDeparture(from);

            var arrivalsOnRoute = GetArivialsAlongRoute(from, to);


        }

        private DateTime GetDeparture(Station departureStation)
        {
            if (_journey.Departs.Station == departureStation) return _journey.Departs.ActualDeparture ?? _journey.Departs.ScheduledDeparture;

            var callingPoint = _journey.Stops.Single(s => s.Station == departureStation);
            return callingPoint.ActualDeparture ?? callingPoint.ScheduledDeparture;
        }

        private IEnumerable<IArrive> GetArivialsAlongRoute(Station from, Station to)
        {

        }
    }
}
