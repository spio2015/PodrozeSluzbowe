using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Database;
using System.Data.Entity;
using System.Windows.Forms;

namespace PodrozeSluzbowe.BusinessClasses
{
    class MenageContext
    {
        PodrozeEntities context = new PodrozeEntities();
        
        public static int AddDestination(string Address, string Latitude, string Longitude)
        {
            using (PodrozeEntities context = new PodrozeEntities())
            {
                Destinations destination = new Destinations();
                destination.Address = Address;
                destination.Latitude = Latitude;
                destination.Longitude = Longitude;
                destination.Active = true;
                context.Destinations.Add(destination);
                context.SaveChanges();
                return destination.Id;
            }
        }

        public static int AddBusinessTrip(int CarId, int DestinationId, int UserId, DateTime DepartureDate, DateTime ArrivalDate)
        {
            using (PodrozeEntities context = new PodrozeEntities())
            {
                BusinessTrips businessTrip = new BusinessTrips();
                businessTrip.CarId = CarId;
                businessTrip.DestinationId = DestinationId;
                businessTrip.UserId = UserId;
                businessTrip.DepartureDate = DepartureDate;
                businessTrip.ArrivalDate = ArrivalDate;
                businessTrip.Active = true;
                context.BusinessTrips.Add(businessTrip);
                int savesDate = context.SaveChanges();
                return businessTrip.Id;
            }
        }

        public static void RemoveTrip(int TripId)
        {
            using (PodrozeEntities context = new PodrozeEntities())
            {
                BusinessTrips businessTrip = context.BusinessTrips.Where(c => c.Id == TripId).First();
                businessTrip.Active = false;
                context.SaveChanges();
            }
        }

        public static List<TravelsGrid> GetTravelsList(DateTime DepartureDate, DateTime ArrivalDate, int DayTolerance, string Lat, string Lng)
        {
            List<TravelsGrid> TravelsGridList = new List<TravelsGrid>();

            using (PodrozeEntities context = new PodrozeEntities())
            {              
                DateTime departureDateFrom = DepartureDate.AddDays(DayTolerance * (-1));
                DateTime departureDateTo = DepartureDate.AddDays(DayTolerance);
                DateTime arrivalDateFrom = ArrivalDate.AddDays(DayTolerance * (-1));
                DateTime arrivalDateTo = ArrivalDate.AddDays(DayTolerance);

                var travelListQuery = (from BusinessTrip in context.BusinessTrips
                                       where BusinessTrip.DepartureDate >= departureDateFrom
                                           && BusinessTrip.DepartureDate <= departureDateTo
                                           && BusinessTrip.ArrivalDate >= arrivalDateFrom
                                           && BusinessTrip.ArrivalDate <= arrivalDateTo
                                           && BusinessTrip.Active == true
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
                    travel.Lat = businessTrip.Destinations.Latitude;
                    travel.Lng = businessTrip.Destinations.Longitude;
                    string startGeolocation = travel.Lat.ToString().Replace(',', '.') + ',' + travel.Lng.ToString().Replace(',', '.');
                    string endGeolocation = Lat.Replace(',', '.') + ',' + Lng.Replace(',', '.');
                    if (startGeolocation == endGeolocation)
                    {
                        travel.Distance = "0";
                        travel.Duration = "0";
                    }
                    else
                    {
                        Dictionary<string, string> result = GoogleApi.GenerateRoute.GetDistance(startGeolocation, endGeolocation, "");
                        travel.Distance = result["distance"];
                        travel.Duration = result["duration"];
                    }
                    TravelsGridList.Add(travel);
                }
            }
            return TravelsGridList;  
        }

        public static List<Cars> GetCars(List<string> reservedCars)
        {
            List<Cars> cars = new List<Cars>();
            using (PodrozeEntities context = new PodrozeEntities())
            {
                cars = context.Cars.Where(c => c.Active == true).ToList();
                foreach (string registration in reservedCars)
                {
                    cars.RemoveAll(c => c.RegistrationNumber == registration);
                }
            }
            return cars;
        }

        public static int GetCarIdByRegistration(string registration)
        {
            int car;
            using (PodrozeEntities context = new PodrozeEntities())
            {
                car = context.Cars.Where(c => c.RegistrationNumber == registration).Select(c => c.Id).First();
            }
            return car;
        }

        public static int GetUserId(string Login)
        {
            int userId = -1;
            using (PodrozeEntities context = new PodrozeEntities())
            {
                List<int> users = context.Users.Where(c => c.Login == Login.ToLower()).Select(c => c.Id).ToList();
                if (users.Count > 0)
                {
                    userId = users[0];
                }
                else
                {
                    MessageBox.Show("Nie znaleziono użytkownika");
                }
            }
            return userId;
        }
    }
}
