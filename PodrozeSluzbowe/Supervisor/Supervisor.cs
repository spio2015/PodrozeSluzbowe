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
        public int AddUser(string Address, string Latitude, string Longitude)
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



            }

            return 0;
        }


    }
}
