namespace Rails.Api.Models
{
    public class Reason
    {
        private string Text { get; set; }
        public bool Applies { get { return !string.IsNullOrWhiteSpace(Text); } }

    }
}