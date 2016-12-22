using Rails.Api.Models;
using Rails.Api.Models.Delay;

namespace Rails.Utilities.Delay
{
    public static class JourneyExtensions
    {
        public static DelayInformation CalculateDelay(this Journey journey, Station from, Station to)
        {
            var calc = new DelayCalculator(journey);

            return new DelayInformation
            {
                Journey = journey,
                TotalDelay = calc.CalculateDelay(from, to)
            };
        }

    }
}
