using System;
using Rails.Api.Models;
using Rails.Api.Proxy;

namespace Rails.Api.Internal
{
    internal class RailsRequestGenerator
    {
        private readonly AccessToken _accessToken;

        public RailsRequestGenerator(Guid accessToken)
        {
            _accessToken = new AccessToken
            {
                TokenValue = accessToken.ToString("D")
            };
        }

        public  CreateRequest<T>(Station from, Station to)
        {
        }


        public GetArrBoardWithDetailsRequest ArriveBoard(Station from, Station to)
        {
            return new GetArrBoardWithDetailsRequest
            {
                crs = to.Code,
                filterCrs = from.Code,
                filterType = FilterType.to,
                numRows = 150,
                timeOffset = -110,
                timeWindow = 60,
                AccessToken = _accessToken
            };
        }
    }
}
