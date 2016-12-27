using System.Collections.Generic;
using Rails.Api.Models;
using Rails.Api.Proxy;

namespace Rails.Api.Internal
{
    internal class RailsResponse
    {
        public IEnumerable<Journey> CreateJourneyList(GetArrBoardWithDetailsResponse resp)
        {
            return new List<Journey>();
        }

        public IEnumerable<Journey> CreateJourneyList(GetDepBoardWithDetailsResponse resp)
        {
            return new List<Journey>();
        }
    }
}