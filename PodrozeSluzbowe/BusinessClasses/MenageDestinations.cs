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


        public void getVarList (DateTime DepartureDate, DateTime ArrivalDate, int DayTolerance)
        {
            using (PodrozeEntities context = new PodrozeEntities())
            {
                var travelListQuery = (from BusinessTrip in context.BusinessTrips
                                       where BusinessTrip.DepartureDate >= DepartureDate.AddDays(DayTolerance * (-1))
                                           && BusinessTrip.DepartureDate <= DepartureDate.AddDays(DayTolerance)
                                           && BusinessTrip.ArrivalDate >= ArrivalDate.AddDays(DayTolerance * (-1))
                                           && BusinessTrip.ArrivalDate >= ArrivalDate.AddDays(DayTolerance)
                                       select BusinessTrip)
                                      .Include(x => x.Users)
                                      .Include(x => x.Destinations.Address)
                                      .Include(x => x.Cars.RegistrationNumber);
                                      
                //new TravelsGrid()
                //                      {
                //                          BusinessTrip.Id,
                //                          BusinessTrip.Users.SurName,
                //                          BusinessTrip.Destinations.Address,
                //                          BusinessTrip.Cars.RegistrationNumber,
                //                          BusinessTrip.DepartureDate,
                //                          BusinessTrip.ArrivalDate
                //                      };
                List<BusinessTrips> BusinessTripsList = travelListQuery.ToList();
            }
        }
    }
}
