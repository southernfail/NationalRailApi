using System;
using Rails.Api.Proxy;

namespace Rails.Api.Internal
{
    internal interface IRailsProxyCaller
    {
        TOut Execute<TIn, TOut>(Func<LDBServiceSoap, Func<TIn, TOut>> methodSelector, TIn request, Guid token) where TIn : IApiRequest;
    }

    class RailsProxyCaller : IRailsProxyCaller
    {
        private readonly IProxyFactory _factory;

        public RailsProxyCaller(IProxyFactory factory)
        {
            _factory = factory;
        }

        public TOut Execute<TIn, TOut>(Func<LDBServiceSoap, Func<TIn, TOut>> methodSelector, TIn request, Guid token) where TIn : IApiRequest
        {
            using (var client = _factory.Create())
            {
                var method = methodSelector(client);

                request.Token = new AccessToken
                {
                    TokenValue = token.ToString("D")
                }; 
                
                return method(request);
            }
        }
    }
}
