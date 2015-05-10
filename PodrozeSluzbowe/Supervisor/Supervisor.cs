using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Database;
using System.Data.Entity;

namespace PodrozeSluzbowe.Supervisor
{
    class Supervisor
    {
        public int AddUser(int Id, string Login, string Password, string FirstName, string SurName, int DepartmentId)
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

            using (PodrozeEntities context = new PodrozeEntities())
            {
                Users users = new Users();
                users.Id = Id;
                users.Login = Login;
                users.Password = Password;
                users.FirstName = FirstName;
                users.SurName = SurName;
                users.DepartmentId = DepartmentId;
                context.Users.Add(users);
                context.SaveChanges();
            }




            return 0;
        }


    }
}
