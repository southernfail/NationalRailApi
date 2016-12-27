namespace Rails.Api.Models.Journeys
{
    public interface IPoint
    {
        Reason CancellationReason { get; set; }
        bool Completed { get; set; }
        Reason DelayReason { get; set; }
        Station Station { get; set; }
    }
}