using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();


        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                {
                    dates.Add(Flights[i].FlightDate);
                }
            }
            return dates;
        }
        public List<DateTime> GetFlightDates2(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            Flights.ForEach(f =>
            {
                if (f.Destination == destination)
                {
                    dates.Add(f.FlightDate);
                };
            }
            );
            return dates;
        }

        public IEnumerable<DateTime> GettFlightDates(string destination)
        {

            foreach (Flight flight in Flights)
            {
                if (flight.Destination == destination)
                {

                    yield return flight.FlightDate;
                }
            }

        }

        public void GetFlights(string filterValue, Func<string, Flight, Boolean> func)
        {

            Func<string, Flight, Boolean> Condition = func;
            foreach (var item in Flights)
            {
                if (Condition(filterValue, item))
                {
                    Console.WriteLine(item);
                }
            }
        }

        public IList<DateTime>GetFlightDates2(string destination)
        {
            //  var query = from f in Flights   
            //            where f.Destination == destination
            //          select f.FlightDate;
            // return query.ToList();
            var query = Flights
                .Where(f => f.Destination == destination)
                .Select(f=>f.FlightDate) .ToList();
            return query;

        }

        public void ShowFlightDetails(Plane plane)
        {

            //   var req=from f in Flights 
            //         where(f.plane== plane)
            //        select new { f.FlightDate, f.Destination};
            // foreach(var item in req)
            // { Console.WriteLine(item.Destination+""+item.FlightDate); }
            var req = Flights
                 .Where(f => f.plane == plane)
                 .Select(f => new { f.FlightDate, f.Destination });
            foreach (var item in req)
            {
                Console.WriteLine(item);
            }
        }


        public int ProgrammedFlightNumber(DateTime startDate)
        {
          /*  var req = from f in Flights
                          //        where ( f.FlightDate > startDate && f.FlightDate< startDate.AddDays(7))
                      where f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7
                      select f;
            return req.Count();*/
            return Flights
                .Where(f => f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7)
                .Count();

        }


        public double DurationAverage(string destination)
        {
            /*var query = from f in Flights
                      where f.Destination == destination
                      select f.EstimatedDuration;
            return query.Average(); */
            var query = Flights
                .Where (f => f.Destination == destination)
                 .Average(f => f.EstimatedDuration);
            return query;


        }

        public IList<Flight> OrderedDurationFlights()
        {

/*            var query = from f in Flights
                        orderby f.EstimatedDuration descending
                        select f;
            return query.ToList();*/


            return Flights
                .OrderByDescending(f => f.EstimatedDuration).ToList();



        }




        public IList<Traveller> SeniorTravellers(Flight flight)
        {

               /*var query=( from f in Flights
                          where f.FlightId== flight.FlightId
                          select f).Single();*/

            return flight.passangers
                .OfType<Traveller>()
                .OrderBy(p=>p.BirthDate).Take(3).ToList();



        }


        public IList<IGrouping<string,Flight>> DestinationGroupedFlights()
        {
            var req= Flights
            //return Flights
                .GroupBy(f => f.Destination).ToList();
            foreach(var item in req)
            {
                 Console.WriteLine("Destination: " +item.Key);
                foreach(var item2 in item)
                {
                    Console.WriteLine("Decollage: "+ item2.FlightDate); 
                
                }

            }
            return req;

        }
        Action<Plane> FlightDetailsDel;
        Func<string,double> DurationAverageDel;

        public ServiceFlight()
        {

        }

    }   
    }
