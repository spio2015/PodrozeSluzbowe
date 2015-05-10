using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Database;
using System.Data.Entity;

namespace PodrozeSluzbowe.Supervisor
{
    class SuperVisor
    {
        public void AddUser(string Login, string Password, string FirstName, string SurName, int DepartmentId)
        {
            /*
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
             */

            if (checkUserInDatabase(Login) == false)
            {
                using (PodrozeEntities context = new PodrozeEntities())
                {
                    Users users = new Users();
                  //  users.Id = Id;
                    users.Login = Login;
                    users.Password = Password;
                    users.FirstName = FirstName;
                    users.SurName = SurName;
                    users.DepartmentId = DepartmentId;
                    context.Users.Add(users);
                    context.SaveChanges();
                    System.Windows.Forms.MessageBox.Show("Użytkownik " + Login + " został utworzony");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Użytkownik " + Login + " znajduje się już w bazie danych");
            }
        }



        public bool checkUserInDatabase(string checkedUser)
        {
            bool isUserInDatabase = false;
            using (PodrozeEntities context = new PodrozeEntities())
            {
                /*
                 var travelListQuery = (from BusinessTrip in context.BusinessTrips
                                       where BusinessTrip.DepartureDate >= departureDateFrom
                                           && BusinessTrip.DepartureDate <= departureDateTo
                                           && BusinessTrip.ArrivalDate >= arrivalDateFrom
                                           && BusinessTrip.ArrivalDate <= arrivalDateTo
                                       select BusinessTrip)
                                      .Include(x => x.Users)
                                      .Include(x => x.Destinations)
                                      .Include(x => x.Cars);
                */
                var userInDatabase = (from user in context.Users 
                                        where user.Login == checkedUser                    
                    select user
                    );
                List<Users> userList = userInDatabase.ToList();
               // System.Windows.Forms.MessageBox.Show(userList.Count.ToString());
                if (userList.Count != 0)
                {
                    isUserInDatabase = true;
                }
            }
            return isUserInDatabase;
        }

    }
}
