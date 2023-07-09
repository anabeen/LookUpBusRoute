using System.Text;

namespace LookUpBusRoute
{
    public class BusRoute
    {
        // bus route 5 will have three stops Overton, Morecambe, and Carnforth;
        // And there are times associated with each stop so figure out how to show them

        public int Route { get; set; }

        public string[] BusStops { get; set; }

        public BusRoute(int route, string[] stops)
        {
            Route = route;
            BusStops = stops;
        }

        public override string ToString()
        {
            StringBuilder busStopString = new StringBuilder();
            foreach (var stop in BusStops) 
            {
                busStopString.Append(stop.ToString());
                busStopString.Append(", ");
            }

            return $"route {Route} : Goes through bus stops {busStopString}";
        }

    }

}