using System;

namespace Rails.Api.Models
{
    public class Station : IEquatable<Station>
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public bool Equals(Station other)
        {
            return other != null && other.Code == this.Code;
        }

        public override string ToString()
        {
            return $"Code: {Code}, Name: {Name}";
        }
    }
}
