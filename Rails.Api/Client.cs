using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rails.Api.Models;

namespace Rails.Api
{
    public interface IRailsClient
    {
        // DEFINE OUR ACTUAL API
        IEnumerable<Journey> GetJourneys(Station from, Station to);

    }

    class Client : IRailsClient
    {
        public static Guid ClientAccessToken { internal get; set; }


        public IEnumerable<Journey> GetJourneys(Station from, Station to)
        {
            return new List<Journey>();

        }
    }
}
