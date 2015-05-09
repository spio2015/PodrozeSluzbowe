using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Database;
using System.Data.Entity;

namespace PodrozeSluzbowe.BusinessClasses
{
    class MenageContext
    {
        PodrozeEntities context = new PodrozeEntities();
        
        public int AddDestination(string Address, double Latitude, double Longitude)
        {
            using (PodrozeEntities context = new PodrozeEntities())
            {
                Destinations destination = new Destinations();
                destination.Address = Address;
                destination.Latitude = Latitude;
                destination.Longitude = Longitude;
                context.Destinations.Add(destination);
                context.SaveChanges();
                return destination.Id;
            }
        }

        public int AddBusinessTrip(int CarId, int DestinationId, int UserId, DateTime DepartureDate, DateTime ArrivalDate)
        {
            using (PodrozeEntities context = new PodrozeEntities())
            {
                BusinessTrips businessTrip = new BusinessTrips();
                businessTrip.CarId = CarId;
                businessTrip.DestinationId = DestinationId;
                businessTrip.UserId = UserId;
                businessTrip.DepartureDate = DepartureDate;
                businessTrip.ArrivalDate = ArrivalDate;
                context.BusinessTrips.Add(businessTrip);
                context.SaveChanges();
                return businessTrip.Id;
            }
        }


        public static List<TravelsGrid> GetTravelsList(DateTime DepartureDate, DateTime ArrivalDate, int DayTolerance)
        {
            using (PodrozeEntities context = new PodrozeEntities())
            {
                List<TravelsGrid> TravelsGridList = new List<TravelsGrid>();

                DateTime departureDateFrom = DepartureDate.AddDays(DayTolerance * (-1));
                DateTime departureDateTo = DepartureDate.AddDays(DayTolerance);
                DateTime arrivalDateFrom = ArrivalDate.AddDays(DayTolerance * (-1));
                DateTime arrivalDateTo = ArrivalDate.AddDays(DayTolerance);

                var travelListQuery = (from BusinessTrip in context.BusinessTrips
                                       where BusinessTrip.DepartureDate >= departureDateFrom
                                           && BusinessTrip.DepartureDate <= departureDateTo
                                           && BusinessTrip.ArrivalDate >= arrivalDateFrom
                                           && BusinessTrip.ArrivalDate <= arrivalDateTo
                                       select BusinessTrip)
                                      .Include(x => x.Users)
                                      .Include(x => x.Destinations)
                                      .Include(x => x.Cars);
                                                     
                List<BusinessTrips> BusinessTripsList = travelListQuery.ToList();

                foreach (BusinessTrips businessTrip in BusinessTripsList)
                {
                    TravelsGrid travel = new TravelsGrid();
                    travel.TripId = businessTrip.Id;
                    travel.UserName = businessTrip.Users.SurName + " " + businessTrip.Users.FirstName;
                    travel.Address = businessTrip.Destinations.Address;
                    travel.RegistrationNumber = businessTrip.Cars.RegistrationNumber;
                    travel.DepartureDate = businessTrip.DepartureDate;
                    travel.ArrivalDate = businessTrip.ArrivalDate;
                    TravelsGridList.Add(travel);
                }

                return TravelsGridList;
            }
        }
    }
}
