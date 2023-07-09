namespace LookUpBusRoute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // single object initialization 
            BusRoute busroute5 = new BusRoute(5,
               new string[] { "Overton", "Morecambe", "Carnforth" });

            // array of objects initialization
            BusRoute[] busroute =
            {
                new BusRoute(40, new string[] {
                    "Morecambe", "Lancaster", "Garstang", "Preston" }),
                new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" }),
                new BusRoute(100, new string[] { "University", "Lancaster", "Morecambe" }),
                new BusRoute(555, new string[] {
                    "Lancaster", "Carnforth", "Kendal", "Windermere", "Keswick" }),
                new BusRoute(5, new string[] { "Overton", "Morecambe", "Carnforth"})
            };

            // two string indexes of times
            string[,] timeRoute5 =
            {
                {"15:40", "16:40", "17:40", "18:40", "19;40"},
                {"16:08", "17:08", "18:08", "19:08", "20:08"},
                {"16:35", "17:35", "18:35", "19:35", ""}
            };

            var findRoute5Times = Array.Find(busroute, route => route.Route == 5);

            Console.WriteLine("Showing the route 5's bus stops and their time through Multidimensional Array: ");
            if (findRoute5Times != null)
            {
                BusTimes busTimesForRoute5 = new BusTimes(findRoute5Times, timeRoute5);

                // loop through the busTimes and show it
                for (int i=0; i< busTimesForRoute5.Busroute.BusStops.Length; i++)
                {
                    Console.Write($"{busTimesForRoute5.Busroute.BusStops[i]}");
                    for (int j=0; j< busTimesForRoute5.TimesForRoute.GetLength(1); j++)
                        Console.Write($"   {busTimesForRoute5.TimesForRoute[i,j]} ");

                    Console.WriteLine();
                }
              
            }

            // Console.WriteLine(busroute);

            //show it in jagged array
            string[][] timeRoute5Jag =
            {
                new string[] {"15:40", "16:40", "17:40", "18:40", "19;40"},
                new string[] {"16:08", "17:08", "18:08", "19:08", "20:08"},
                new string[] {"16:35", "17:35", "18:35", "19:35"}
            };

            Console.WriteLine("Showing the route 5's bus stops and their time through Jagged Array: ");
            if (findRoute5Times != null)
            {
                BusTimesJagged busTimesJagged = 
                    new BusTimesJagged(findRoute5Times, timeRoute5Jag);

                for (int i = 0; i < busTimesJagged.Busroute.BusStops.Length; i++)
                {
                    Console.Write($"{busTimesJagged.Busroute.BusStops[i]}");
                    for (int j = 0; j < busTimesJagged.TimesForRoute[i].Length; j++)
                    {
                        Console.Write($"   {busTimesJagged.TimesForRoute[i][j]} ");
                    }
                    Console.WriteLine();

                }
            }


        }


    }
}