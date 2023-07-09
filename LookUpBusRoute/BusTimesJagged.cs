namespace LookUpBusRoute
{
    public class BusTimesJagged
    {
        // time assocaited with route
        public string[][] TimesForRoute { get; set; }

        public BusRoute Busroute { get; set; }

        public BusTimesJagged(BusRoute route, string[][] timesForroute)
        {
            Busroute = route;
            TimesForRoute = timesForroute;
        }
    }

}