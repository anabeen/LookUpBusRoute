namespace LookUpBusRoute
{
    public class BusTimes
    {
        // time assocaited with route
        public string[,] TimesForRoute {get;set;}

        public BusRoute Busroute { get;set;}

        public BusTimes(BusRoute route, string[,] timesForroute)
        {
            Busroute = route;
            TimesForRoute = timesForroute;
        }
    }

}