using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Database;

namespace PodrozeSluzbowe.BusinessClasses
{
    class TravelsGrid
    {
        private int tripId;
        private string userName;
        private string address;
        private string lat;
        private string lng;
        private string registrationNumber;
        private DateTime departureDate;
        private DateTime arrivalDate;
        private string distance;
        private string duration;

	    public int TripId
	    {
		    get { return tripId;}
		    set { tripId = value;}
	    }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Lat
        {
            get { return lat; }
            set { lat = value; }
        }
        public string Lng
        {
            get { return lng; }
            set { lng = value; }
        }
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }
        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }
        public string Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
