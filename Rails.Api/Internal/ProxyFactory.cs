using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Rails.Api.Proxy;

namespace Rails.Api.Internal
{
    internal interface IProxyFactory
    {
        LDBServiceSoap Create();

    }

    internal class ProxyFactory : IProxyFactory
    {
        public LDBServiceSoap Create()
        {
            var client = new LDBServiceSoapClient();

            return client;
        }


    }
}
