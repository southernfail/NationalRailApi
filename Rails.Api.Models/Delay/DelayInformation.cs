using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rails.Api.Models.Delay
{
    public class DelayInformation
    {
        public Journey Journey { get; set; }
        public TimeSpan TotalDelay { get; set; }
    }
}
