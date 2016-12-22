namespace Rails.Api.Models.Journeys
{
    public interface IStop : IArrive, IDepart
    {
        new Station Station { get; set; }
    }
}