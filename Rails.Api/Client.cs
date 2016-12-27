using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Rails.Api.Internal;
using Rails.Api.Models;
using Rails.Api.Proxy;

namespace Rails.Api
{
    public interface IRailsClient
    {
        // DEFINE OUR ACTUAL API
        IEnumerable<Journey> GetJourneys(Station from, Station to);
    }


    public class Client : IRailsClient
    {
        //07c1d857-d4d1-4c67-97e4-b3b8e34a154d - DO NOT COMMIT THIS LINE

        private readonly RailsResponse _responses;
        private readonly RailsRequestGenerator _requests;
        private readonly Func<LDBServiceSoap> _factory;

        #region Ctor

        public Client(Guid accessToken)
        {
            _requests = new RailsRequestGenerator(accessToken);
            _responses = new RailsResponse();
            _factory = () => new LDBServiceSoapClient();
        }

        public Client(Guid accessToken, string endpointConfigurationName)
        {
            _requests = new RailsRequestGenerator(accessToken);
            _responses = new RailsResponse();
            _factory = () => new LDBServiceSoapClient(endpointConfigurationName);
        }

        public Client(Guid accessToken, string endpointConfigurationName, string remoteAddress) 
        {
            _requests = new RailsRequestGenerator(accessToken);
            _responses = new RailsResponse();
            _factory = () => new LDBServiceSoapClient(endpointConfigurationName, remoteAddress);
        }

        public Client(Guid accessToken, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress)
        {
            _requests = new RailsRequestGenerator(accessToken);
            _responses = new RailsResponse();
            _factory = () => new LDBServiceSoapClient(endpointConfigurationName, remoteAddress);
        }

        public Client(Guid accessToken, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { 
            _requests = new RailsRequestGenerator(accessToken);
            _responses = new RailsResponse();
            _factory = () => new LDBServiceSoapClient(binding, remoteAddress);
        }

        #endregion

        #region API
        public IEnumerable<Journey> GetJourneys(Station from, Station to)
        {
            return Process(r => r.ArriveBoard(from, to), r => r.CreateJourneyList, s => s.GetArrBoardWithDetails);

            

        }

        #endregion


        private void thang<Tin,Tout>()
        {
            var thing = _factory().GetArrBoardWithDetails;
        }

        private TResult Process<TResult, TRequest, TResponse, TMethod>(Func<RailsRequestGenerator, TRequest> request, Func<RailsResponse, Func<TResponse, TResult>> resultMapper,
           Func<LDBServiceSoap, TMethod> methodSelector)
        {
            using (var proxy = _factory())
            {
                var req = request(_requests);

                var response = methodSelector(proxy)(req);

                return resultMapper(_responses)(response);
            }

        }
    }

}
