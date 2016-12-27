using System;
using Rails.Api.Models.Journeys;

namespace Rails.Api.Models.Timing
{
    public class TimingInformation
    {
        public IPoint PointOnJourney { get; set; }
        public Journey Journey { get; set; }
        public TimeSpan TimingDiffernece { get; set; }
        public TimingType Type { get; set; }
    }
}
