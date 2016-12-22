using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rails.Api.Models;
using Rails.Api.Models.Journeys;

namespace Rails.Harness
{
    class Program
    {
        static void Main(string[] args)
        {
            var station = new Station
            {
                Code = "abc",
                Name = "test"
            };

            Console.WriteLine("Begin test with station {0}", station);
            t.dosum(station);
            Console.ReadLine();
        }
    }

    public static class t
    {
        public static void dosum(Station station)
        {
            var t = new Stop
            {
                Station = station
            };

            arrv(t);
            dept(t);
            stop(t);
        }

        public static void arrv(IArrive arrive)
        {
            Write("IArrive", arrive.Station);
        }

        public static void dept(IDepart dept)
        {
            Write("IDepart", dept.Station);
        }

        public static void stop(IStop stop)
        {
            Write("IStop", stop.Station);
        }

        private static void Write(string stationType, Station value)
        {
            Console.WriteLine($"{stationType} Station: {value}");
        }
    }
}
