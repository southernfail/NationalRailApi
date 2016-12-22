namespace Rails.Api.Models.Journeys
{
    public abstract class Point
    {
        public Station Station { get; set; }
        public bool Completed { get; set; }
        public Reason CancellationReason { get; set; }
        public Reason DelayReason { get; set; }
    }
}